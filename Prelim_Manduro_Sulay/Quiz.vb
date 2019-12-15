Public Class Quiz
    'For Timer
    Dim min As Integer
    Dim sec As Integer
    'contain questions
    Dim ques(15) As String

    'contain the possible choices of the user
    '0-14 will contain choices for a
    '15-29 will contain choices for b
    '30-44 will contain choices for c
    '45-59nwill contain choices for d
    Dim choices(60) As String


    'contains answers
    Dim answers(15) As Char

    'contains user score
    Dim score As Integer

    'contains index
    Dim startNum As Integer

    'flag to indicate when to proceed and what to do
    '1 is to progress  the ctr of questions
    '2 is to create a new question
    '0 default
    Dim flag As Integer

    'main
    Private Sub Quiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Main()
        choices(0) = "Percentage"
        choices(1) = "Fruit"
        choices(2) = "Comforter"
        choices(3) = "3 days"
        choices(4) = "Alex"
        choices(5) = "Hell"
        choices(6) = "America"
        choices(7) = "Mercury"
        choices(8) = "China"
        choices(9) = "Philippines"
        choices(10) = "Yahoo"
        choices(11) = "Elmo"
        choices(12) = "Cheese"
        choices(13) = "Mars and Murrie"
        choices(14) = "Mounain Dew"
        choices(15) = "Hashtag"
        choices(16) = "Color"
        choices(17) = "Bed sheet"
        choices(18) = "3 years"
        choices(19) = "Sid"
        choices(20) = "Oslo"
        choices(21) = "Brazil"
        choices(22) = "Saturn"
        choices(23) = "Russia"
        choices(24) = "India"
        choices(25) = "Google"
        choices(26) = "Spongebob"
        choices(27) = "Beer"
        choices(28) = "Mix and Match"
        choices(29) = "Sprite"
        choices(30) = "Question mark"
        choices(31) = "Person"
        choices(32) = "Socks"
        choices(33) = "3 centuries"
        choices(34) = "Freddie"
        choices(35) = "Drammen"
        choices(36) = "Britain"
        choices(37) = "Pluto"
        choices(38) = "Nigeria"
        choices(39) = "Egypt"
        choices(40) = "Tesla"
        choices(41) = "Phineas"
        choices(42) = "Candy"
        choices(43) = "Marshall Matthers"
        choices(44) = "Coca Cola"
        choices(45) = "Bracket"
        choices(46) = "Food"
        choices(47) = "3D wallpaper"
        choices(48) = "3 months"
        choices(49) = "Elmo"
        choices(50) = "Skien"
        choices(51) = "Portugal"
        choices(52) = "Jupiter"
        choices(53) = "France"
        choices(54) = "Ethiopia"
        choices(55) = "Honda"
        choices(56) = "Tom"
        choices(57) = "Rice"
        choices(58) = "Nothing"
        choices(59) = "Royal"


        answers(0) = "b"c
        answers(1) = "a"c
        answers(2) = "d"c
        answers(3) = "b"c
        answers(4) = "b"c
        answers(5) = "a"c
        answers(6) = "c"c
        answers(7) = "c"c
        answers(8) = "a"c
        answers(9) = "d"c
        answers(10) = "b"c
        answers(11) = "a"c
        answers(12) = "c"c
        answers(13) = "a"c
        answers(14) = "c"c

        ques(0) = "Which symbol is technically called an octothorpe?"
        ques(1) = "The word 'orange' was first used to describe the _____?"
        ques(2) = "Bubble Wrap was originally intended to be used as?"
        ques(3) = "How long can a snail sleep?"
        ques(4) = "What is the real name of Cookie Monster?"
        ques(5) = "Which country in norway freezes every winter"
        ques(6) = "Where did the word 'soccer' come from?"
        ques(7) = "Which planet’s average distance is 3,670,050,000 miles from the sun?"
        ques(8) = "Which country has a population of more than 1 billion people?"
        ques(9) = "Which is the hottest inhabited place on earth?"
        ques(10) = "which company was originally called Backrub?"
        ques(11) = "Who was the only non-human to testify before the congress?"
        ques(12) = "Which is the most shoplifted food item in the U.S.? "
        ques(13) = "What does m & m stand for?"
        ques(14) = "What was the first soft drink in space?"

        Cont_Load(Randomizer())
        'set timer
        min = 15
        sec = 0

        'set format for timer
        Label2.Text = Format(min, "00") & " : " & Format(sec, "00")
        'contains counter
        Dim ctr As Integer
        ctr = 0
        flag = 0
        Timer1.Start()
        startNum = Randomizer()

        'will only do something if one is returned
        While (ctr < 10 Or (min = 0 And sec = 0))
            If (flag <> 0) Then
                Select Case flag
                    Case 1
                        ctr = ctr + 1
                        Cont_Load(Randomizer())
                    Case 2
                        Cont_Load(Randomizer())
                    Case 3
                        ctr = 0
                        Cont_Load(Randomizer())
                End Select

                flag = 0
            End If
        End While
    End Sub
    'loads question
    Private Sub Cont_Load(ind As Integer)
        Label1.Text = "Question: " & ques(ind)
        a.Text = "A. " & choices(ind)
        b.Text = "B. " & choices(ind + 15)
        c.Text = "C. " & choices(ind + 30)
        d.Text = "D. " & choices(ind + 45)

    End Sub

    'Function for creating random Integers for index display
    Private Function Randomizer() As Integer
        Dim value As Integer
        Return value = CInt(Int(15 * Rnd()))
    End Function

    'Checks the answers from button click and increment the new 
    'Will return 1 to progress quiz
    Private Sub Check(v As Char)
        If v = answers(startNum) Then
            score = score + 1
        End If
        flag = 1
    End Sub

    Private Sub Go_Click(sender As Object, e As EventArgs) Handles Go.Click
        If (Go.Visible = True) Then
            Timer1.Enabled = True
            Go.Visible = False
            Pause.Visible = True
        End If
    End Sub

    Private Sub Pause_Click(sender As Object, e As EventArgs) Handles Pause.Click
        If (Pause.Visible = True) Then
            Timer1.Enabled = False
            Pause.Visible = False
            Go.Visible = True
        End If
    End Sub

    Private Sub a_Click(sender As Object, e As EventArgs) Handles a.Click
        If (Timer1.Enabled = True) Then
            Check("a"c)
        End If
    End Sub

    Private Sub b_Click(sender As Object, e As EventArgs) Handles b.Click
        If (Timer1.Enabled = True) Then
            Check("b"c)
        End If
    End Sub

    Private Sub c_Click(sender As Object, e As EventArgs) Handles c.Click
        If (Timer1.Enabled = True) Then
            Check("c"c)
        End If
    End Sub

    Private Sub d_Click(sender As Object, e As EventArgs) Handles d.Click
        If (Timer1.Enabled = True) Then
            Check("d"c)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        flag = 3
    End Sub

    'For Clock
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Main()
        sec = sec - 1
        If (sec < 0) Then
            min = min - 1
            sec = 59
        End If

        Label2.Text = Format(min, "00") & " : " & Format(sec, "00")
    End Sub
End Class