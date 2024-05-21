<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class client
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        txt_hotel = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label6 = New Label()
        DataGridView1 = New DataGridView()
        Panel1 = New Panel()
        Label7 = New Label()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(92, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 21)
        Label1.TabIndex = 9
        Label1.Text = "Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(87, 105)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(106, 23)
        TextBox1.TabIndex = 8
        ' 
        ' txt_hotel
        ' 
        txt_hotel.AutoSize = True
        txt_hotel.BackColor = SystemColors.ActiveCaptionText
        txt_hotel.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_hotel.ForeColor = SystemColors.ButtonHighlight
        txt_hotel.Location = New Point(340, 23)
        txt_hotel.Name = "txt_hotel"
        txt_hotel.Size = New Size(156, 32)
        txt_hotel.TabIndex = 7
        txt_hotel.Text = "Barani Hotel"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(214, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 21)
        Label2.TabIndex = 11
        Label2.Text = "Age"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(209, 105)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(106, 23)
        TextBox2.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(340, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 21)
        Label3.TabIndex = 13
        Label3.Text = "Phone"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(335, 105)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(106, 23)
        TextBox3.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(461, 78)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 21)
        Label4.TabIndex = 15
        Label4.Text = "Country"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(590, 78)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 21)
        Label5.TabIndex = 17
        Label5.Text = "Gender"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Pakistan", "USA", "UK", "UAE", "Other"})
        ComboBox1.Location = New Point(461, 105)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(107, 23)
        ComboBox1.TabIndex = 18
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Male", "Female", "Prefer not to say"})
        ComboBox2.Location = New Point(590, 105)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(109, 23)
        ComboBox2.TabIndex = 19
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(257, 154)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 20
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(357, 154)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 21
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(455, 154)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 22
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(545, 154)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 23
        Button4.Text = "Reset"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ButtonFace
        Label6.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(357, 206)
        Label6.Name = "Label6"
        Label6.Size = New Size(143, 32)
        Label6.TabIndex = 24
        Label6.Text = "Client's List"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(196, 269)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(543, 300)
        DataGridView1.TabIndex = 25
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Label7)
        Panel1.Location = New Point(4, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(189, 567)
        Panel1.TabIndex = 26
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ButtonFace
        Label7.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(8, 21)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 32)
        Label7.TabIndex = 27
        Label7.Text = "Clients"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(24, 138)
        Button5.Name = "Button5"
        Button5.Size = New Size(100, 30)
        Button5.TabIndex = 28
        Button5.Text = "Room"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(24, 98)
        Button6.Name = "Button6"
        Button6.Size = New Size(100, 30)
        Button6.TabIndex = 29
        Button6.Text = "Staff"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(24, 178)
        Button7.Name = "Button7"
        Button7.Size = New Size(100, 30)
        Button7.TabIndex = 30
        Button7.Text = "Reservation"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' client
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(741, 574)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        Controls.Add(Label6)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox3)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(txt_hotel)
        FormBorderStyle = FormBorderStyle.None
        Name = "client"
        StartPosition = FormStartPosition.CenterScreen
        Text = "client"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txt_hotel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label7 As Label
End Class
