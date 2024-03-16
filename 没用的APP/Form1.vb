Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Value = 0
        ProgressBar1.Value = 100
        MsgBox("系统鉴定您为 ： 女性", vbInformation, "Success")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProgressBar1.Value = 0
        ProgressBar1.Value = 100
        MsgBox("系统鉴定您为 ： 男性", vbInformation, "Success")
    End Sub

    Private Sub 帮助_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub GithubToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GithubToolStripMenuItem.Click
        Shell("Explorer https://github.com/Bladeless114514/-byVB")
    End Sub

    Private Sub HowToUseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToUseToolStripMenuItem.Click
        MsgBox("按照你的真实情况点击下方的按钮 如果没有对应的选项请联系Github作者", vbInformation, "Help")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit
    End Sub

    Private Sub 神奇の按钮ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 神奇の按钮ToolStripMenuItem.Click
        Shell("explorer https://www.bilibili.com/video/BV1va411w7aM/")
    End Sub
End Class
