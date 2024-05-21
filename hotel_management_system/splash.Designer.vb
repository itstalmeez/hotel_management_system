<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class splash
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
        txt_hotel = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(-1, 415)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(801, 23)
        ProgressBar1.TabIndex = 0
        ' 
        ' txt_hotel
        ' 
        txt_hotel.AutoSize = True
        txt_hotel.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_hotel.Location = New Point(211, 34)
        txt_hotel.Name = "txt_hotel"
        txt_hotel.Size = New Size(368, 32)
        txt_hotel.TabIndex = 1
        txt_hotel.Text = "HOTEL MANAGEMENT SYSTEM"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(361, 171)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 50)
        Label1.TabIndex = 2
        Label1.Text = "%"
        ' 
        ' splash
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(txt_hotel)
        Controls.Add(ProgressBar1)
        FormBorderStyle = FormBorderStyle.None
        Name = "splash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents txt_hotel As Label
    Friend WithEvents Label1 As Label

End Class
