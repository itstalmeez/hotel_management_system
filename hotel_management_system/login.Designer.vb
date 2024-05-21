<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        txt_hotel = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        CheckBox1 = New CheckBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(txt_hotel)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(505, 386)
        Panel1.TabIndex = 0
        ' 
        ' txt_hotel
        ' 
        txt_hotel.AutoSize = True
        txt_hotel.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_hotel.ForeColor = SystemColors.ButtonHighlight
        txt_hotel.Location = New Point(144, 22)
        txt_hotel.Name = "txt_hotel"
        txt_hotel.Size = New Size(180, 32)
        txt_hotel.TabIndex = 2
        txt_hotel.Text = "Account Login"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(112, 124)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(262, 23)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(112, 185)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(262, 23)
        TextBox2.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(117, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 21)
        Label1.TabIndex = 6
        Label1.Text = "Id"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(117, 161)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 21)
        Label2.TabIndex = 7
        Label2.Text = "Password"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(150, 273)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 38)
        Button1.TabIndex = 8
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(256, 273)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 38)
        Button2.TabIndex = 9
        Button2.Text = "Admin"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(117, 231)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(108, 19)
        CheckBox1.TabIndex = 10
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(504, 385)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_hotel As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
