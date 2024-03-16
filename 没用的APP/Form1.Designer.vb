<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ProgressBar1 = New ProgressBar()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        MenuStrip1 = New MenuStrip()
        帮助ToolStripMenuItem = New ToolStripMenuItem()
        GithubToolStripMenuItem = New ToolStripMenuItem()
        HowToUseToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        神奇の按钮ToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(0, 111)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(198, 23)
        ProgressBar1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 17)
        Label1.TabIndex = 1
        Label1.Text = "欢迎使用性别计算器"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(0, 82)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "我是男的♂"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(122, 82)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 3
        Button2.Text = "我是女的♀"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {帮助ToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(209, 25)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' 帮助ToolStripMenuItem
        ' 
        帮助ToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GithubToolStripMenuItem, HowToUseToolStripMenuItem, ExitToolStripMenuItem, 神奇の按钮ToolStripMenuItem})
        帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        帮助ToolStripMenuItem.Size = New Size(44, 21)
        帮助ToolStripMenuItem.Text = "帮助"
        ' 
        ' GithubToolStripMenuItem
        ' 
        GithubToolStripMenuItem.Name = "GithubToolStripMenuItem"
        GithubToolStripMenuItem.Size = New Size(180, 22)
        GithubToolStripMenuItem.Text = "Github"
        ' 
        ' HowToUseToolStripMenuItem
        ' 
        HowToUseToolStripMenuItem.Name = "HowToUseToolStripMenuItem"
        HowToUseToolStripMenuItem.Size = New Size(180, 22)
        HowToUseToolStripMenuItem.Text = "How to use?"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(180, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' 神奇の按钮ToolStripMenuItem
        ' 
        神奇の按钮ToolStripMenuItem.Name = "神奇の按钮ToolStripMenuItem"
        神奇の按钮ToolStripMenuItem.Size = New Size(180, 22)
        神奇の按钮ToolStripMenuItem.Text = "神奇の按钮"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(209, 149)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(ProgressBar1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "性别计算器"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 帮助ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GithubToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HowToUseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 神奇の按钮ToolStripMenuItem As ToolStripMenuItem

End Class
