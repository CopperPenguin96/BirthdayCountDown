Public Class Form1
    Public currentDate As DateTime = DateTime.Now
    Dim ShowLBL As Boolean = True
    Private Sub Countdown_Tick(sender As Object, e As EventArgs) Handles Countdown.Tick
        'Starts the Days Function
        Days()
        'Starts the Hours Function
        Hours()
        'Starts the Minutes Function
        Minutes()
        'Starts the Seconds Function
        Seconds()
        'Starts the MilliSeconds Function
        MilliSeconds()
        'Keeps the labels up to date with the current times
        lblDays.Text = Days() & " Days"
        lblHours.Text = Hours() & " Hours"
        lblMinutes.Text = Minutes() & " Minutes"
        lblSeconds.Text = Seconds() & " Seconds"
        lblHalfSeconds.Text = MilliSeconds() & " MilliSeconds"
        'Starts the text change sub procedure
        TextChange()
        'If the day matches, then it turns on the BirthdayOn Sub Procedure
        If currentDate.Month = 2 Then
            If currentDate.Day = 8 Then
                BirthdayOn()
            End If
        End If
    End Sub
    Sub BirthdayOn()
        'Turns on the Fireworks
        picFireworks.Show()
        If ShowLBL Then
            'Turns off the rest of the sub procedure
            ShowLBL = False
            'Activates the rest of this code
            lblHeader.Text = "Happy Birthday!"
            'Hides the time labels
            lblDays.Hide()
            lblHalfSeconds.Hide()
            lblHours.Hide()
            lblMinutes.Hide()
            lblSeconds.Hide()
            MsgBox("Happy 18th Birthday!")
        Else
            'Changes the title of the form
            Title()
        End If
    End Sub
    Sub Title()
        Me.Text = "HAPPY BIRTHDAY!"
    End Sub
    Function Days() As Integer
        'Get the current Date
        Dim thisDay As Integer = Microsoft.VisualBasic.DateAndTime.Day(Now)
        Dim BirthDate As Integer
        If currentDate.Month = 1 Then
            BirthDate = 31 - System.DateTime.Now.Day + 8
        ElseIf currentDate.Month = 2 Then
            If currentDate.Day = 8 Then
                BirthDate = 8 - System.DateTime.Now.Day
            ElseIf currentDate.Day >= 9 Then
                MsgBox("It is past your birthday! Sorry!")
            End If
        Else
            MsgBox("Past your birthday month! Hope you have another good year!")
        End If
            Return BirthDate
    End Function
    Function Hours() As Integer
        'Get the Current Hour
        Dim HoursInt As Integer = 24 - System.DateTime.Now.Hour
        Return HoursInt
    End Function
    Function Minutes() As Integer
        'Gets the Current Minutes
        Dim MinutesInt As Integer = 60 - System.DateTime.Now.Minute
        Return MinutesInt
    End Function
    Function Seconds() As Integer
        'Get the Current Seconds
        Dim SecondsInt As Integer = 60 - System.DateTime.Now.Second
        Return SecondsInt
    End Function
    Function MilliSeconds() As Integer
        'Gets the Current MilliSeconds
        Dim MilliInt As Integer = 1000 - System.DateTime.Now.Millisecond
        Return MilliInt
    End Function
    Sub TextChange()
        'Changes the Form Text
        'Changes it to match the time per Timer Tick
        Me.Text = "Birthday Countdown | " & Days() & ":" & Hours() & ":" & Minutes() & ":" & Seconds() & ":" & MilliSeconds()
    End Sub
End Class
