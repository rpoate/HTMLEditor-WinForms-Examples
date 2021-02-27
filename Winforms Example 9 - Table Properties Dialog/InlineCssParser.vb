Imports System.Text

Friend NotInheritable Class InlineCssParser
    Public Sub New(ByVal rawInlineCss As String)
        InlineCss = If(rawInlineCss, String.Empty)
    End Sub

    Public Property InlineCss As String

    Public Sub SetValue(ByVal name As String, ByVal value As String)
        Dim dic = parse(InlineCss)
        setDictionary(dic, name, value)
        InlineCss = combine(dic)
    End Sub

    Public Function GetValue(ByVal name As String) As String
        Return getDictionary(parse(InlineCss), name)
    End Function

    Public Sub RemoveItem(ByVal name As String)
        Dim dic = parse(InlineCss)
        removeFromDictionary(dic, name)
        InlineCss = combine(dic)
    End Sub

    Public Function HasName(ByVal name As String) As Boolean
        Return hasDictionary(parse(InlineCss), name)
    End Function

    Private Shared Function combine(ByVal dic As ICollection(Of KeyValuePair(Of String, String))) As String
        If dic Is Nothing OrElse dic.Count <= 0 Then
            Return String.Empty
        Else
            Dim result = New StringBuilder()

            For Each pair As KeyValuePair(Of String, String) In dic
                If result.Length > 0 Then result.Append("; ")
                result.AppendFormat("{0}: {1}", pair.Key, pair.Value)
            Next

            Return result.ToString()
        End If
    End Function

    Private Shared Function parse(ByVal raw As String) As Dictionary(Of String, String)
        Dim result = New Dictionary(Of String, String)()

        If Not raw Is Nothing Then
            Dim firsts = raw.Split({";"c}, StringSplitOptions.RemoveEmptyEntries)

            For Each first As String In firsts
                Dim f = first.Trim()

                If Not String.IsNullOrEmpty(f) Then
                    Dim seconds = f.Split({":"c}, StringSplitOptions.RemoveEmptyEntries)

                    If seconds.Length = 2 Then
                        Dim a = seconds(0).Trim().ToLowerInvariant()
                        Dim b = seconds(1).Trim()

                        If Not String.IsNullOrEmpty(a) AndAlso Not String.IsNullOrEmpty(b) Then
                            If a <> "border" Then
                                setDictionary(result, a, b)
                            Else
                                Dim borders = b.Split({" "c}, 3, StringSplitOptions.RemoveEmptyEntries)
                                setDictionary(result, "border-width", borders(0))
                                setDictionary(result, "border-style", borders(1))
                                setDictionary(result, "border-color", borders(2))
                            End If

                        End If
                    End If
                End If
            Next
        End If

        Return result
    End Function

    Private Shared Function getDictionary(ByVal dic As IDictionary(Of String, String), ByVal a As String) As String
        Return If(dic.ContainsKey(a.ToLowerInvariant()), dic(a.ToLowerInvariant()), Nothing)
    End Function

    Private Shared Function hasDictionary(ByVal dic As IDictionary(Of String, String), ByVal a As String) As Boolean
        Return dic.ContainsKey(a.ToLowerInvariant())
    End Function

    Private Shared Sub removeFromDictionary(ByVal dic As IDictionary(Of String, String), ByVal a As String)
        If dic.ContainsKey(a.ToLowerInvariant()) Then
            dic.Remove(a.ToLowerInvariant())
        End If
    End Sub

    Private Shared Sub setDictionary(ByVal dic As IDictionary(Of String, String), ByVal a As String, ByVal b As String)
        If dic.ContainsKey(a.ToLowerInvariant()) Then
            dic(a.ToLowerInvariant()) = b
        Else
            dic.Add(a.ToLowerInvariant(), b)
        End If
    End Sub
End Class

