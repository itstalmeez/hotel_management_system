<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staff
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
        Button7 = New Button()
        Button5 = New Button()
        Label7 = New Label()
        Panel1 = New Panel()
        Button6 = New Button()
        DataGridView1 = New DataGridView()
        Label6 = New Label()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        txt_hotel = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        ' Button5
        ' 
        Button5.Location = New Point(24, 91)
        Button5.Name = "Button5"
        Button5.Size = New Size(100, 30)
        Button5.TabIndex = 28
        Button5.Text = "Clients"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ButtonFace
        Label7.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(8, 21)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 32)
        Label7.TabIndex = 27
        Label7.Text = "Staff"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Label7)
        Panel1.Location = New Point(3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(189, 567)
        Panel1.TabIndex = 44
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(24, 132)
        Button6.Name = "Button6"
        Button6.Size = New Size(100, 30)
        Button6.TabIndex = 29
        Button6.Text = "Room"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(195, 271)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(543, 300)
        DataGridView1.TabIndex = 43
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ButtonFace
        Label6.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(356, 208)
        Label6.Name = "Label6"
        Label6.Size = New Size(140, 32)
        Label6.TabIndex = 42
        Label6.Text = "Agents List"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(544, 156)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 41
        Button4.Text = "Reset"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(454, 156)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 40
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(356, 156)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 39
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(256, 156)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 38
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Male", "Female", "Prefer not to say"})
        ComboBox2.Location = New Point(589, 107)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(109, 23)
        ComboBox2.TabIndex = 37
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Pakistan", "USA", "UK", "UAE", "Other"})
        ComboBox1.Location = New Point(460, 107)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(107, 23)
        ComboBox1.TabIndex = 36
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(589, 80)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 21)
        Label5.TabIndex = 35
        Label5.Text = "Gender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(460, 80)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 21)
        Label4.TabIndex = 34
        Label4.Text = "Country"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(339, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 21)
        Label3.TabIndex = 33
        Label3.Text = "Phone"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(334, 107)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(106, 23)
        TextBox3.TabIndex = 32
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(213, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 21)
        Label2.TabIndex = 31
        Label2.Text = "Age"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(208, 107)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(106, 23)
        TextBox2.TabIndex = 30
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(86, 107)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(106, 23)
        TextBox1.TabIndex = 28
        ' 
        ' txt_hotel
        ' 
        txt_hotel.AutoSize = True
        txt_hotel.BackColor = SystemColors.ActiveCaptionText
        txt_hotel.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_hotel.ForeColor = SystemColors.ButtonHighlight
        txt_hotel.Location = New Point(339, 25)
        txt_hotel.Name = "txt_hotel"
        txt_hotel.Size = New Size(156, 32)
        txt_hotel.TabIndex = 27
        txt_hotel.Text = "Barani Hotel"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(91, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 21)
        Label1.TabIndex = 29
        Label1.Text = "Name"
        ' 
        ' staff
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
        Controls.Add(TextBox1)
        Controls.Add(txt_hotel)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "staff"
        StartPosition = FormStartPosition.CenterScreen
        Text = "staff"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button7 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txt_hotel As Label
    Friend WithEvents Label1 As Label
End Class
