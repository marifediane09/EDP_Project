<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.ItemImage = New System.Windows.Forms.PictureBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.ItemName = New System.Windows.Forms.Label()
        Me.ItemPrice = New System.Windows.Forms.Label()
        Me.RentButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AvailableItemsListBox = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.ItemImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ItemImage
        '
        Me.ItemImage.Image = Global.UXEDP.My.Resources.Resources.barong
        Me.ItemImage.Location = New System.Drawing.Point(26, 42)
        Me.ItemImage.Name = "ItemImage"
        Me.ItemImage.Size = New System.Drawing.Size(282, 329)
        Me.ItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ItemImage.TabIndex = 1
        Me.ItemImage.TabStop = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.ItemName)
        Me.Panel8.Controls.Add(Me.ItemPrice)
        Me.Panel8.Controls.Add(Me.ItemImage)
        Me.Panel8.Controls.Add(Me.RentButton)
        Me.Panel8.Location = New System.Drawing.Point(555, 44)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(338, 435)
        Me.Panel8.TabIndex = 4
        '
        'ItemName
        '
        Me.ItemName.AutoSize = True
        Me.ItemName.Font = New System.Drawing.Font("Martina", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ItemName.Location = New System.Drawing.Point(121, 10)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(79, 29)
        Me.ItemName.TabIndex = 3
        Me.ItemName.Text = "Barong"
        '
        'ItemPrice
        '
        Me.ItemPrice.AutoSize = True
        Me.ItemPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ItemPrice.Location = New System.Drawing.Point(203, 335)
        Me.ItemPrice.Name = "ItemPrice"
        Me.ItemPrice.Size = New System.Drawing.Size(0, 18)
        Me.ItemPrice.TabIndex = 2
        '
        'RentButton
        '
        Me.RentButton.BackColor = System.Drawing.Color.LightBlue
        Me.RentButton.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RentButton.ForeColor = System.Drawing.SystemColors.InfoText
        Me.RentButton.Location = New System.Drawing.Point(105, 377)
        Me.RentButton.Name = "RentButton"
        Me.RentButton.Size = New System.Drawing.Size(121, 44)
        Me.RentButton.TabIndex = 0
        Me.RentButton.Text = "RENT"
        Me.RentButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(581, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Barong"
        '
        'AvailableItemsListBox
        '
        Me.AvailableItemsListBox.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AvailableItemsListBox.FormattingEnabled = True
        Me.AvailableItemsListBox.ItemHeight = 26
        Me.AvailableItemsListBox.Location = New System.Drawing.Point(316, 96)
        Me.AvailableItemsListBox.Name = "AvailableItemsListBox"
        Me.AvailableItemsListBox.Size = New System.Drawing.Size(195, 342)
        Me.AvailableItemsListBox.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Location = New System.Drawing.Point(232, -6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(778, 44)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel3.Location = New System.Drawing.Point(12, 81)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(14, 50)
        Me.Panel3.TabIndex = 15
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel6.Location = New System.Drawing.Point(12, 302)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(14, 50)
        Me.Panel6.TabIndex = 14
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightBlue
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Button4.Location = New System.Drawing.Point(0, 302)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(234, 50)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Profile"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel5.Location = New System.Drawing.Point(12, 226)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(14, 50)
        Me.Panel5.TabIndex = 12
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightBlue
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button5.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Button5.Location = New System.Drawing.Point(0, 226)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(234, 50)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Orders"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel4.Location = New System.Drawing.Point(12, 150)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(14, 50)
        Me.Panel4.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightBlue
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Button3.Location = New System.Drawing.Point(0, 150)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(234, 50)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Categories"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Martina", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(40, 403)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 42)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "EasyRent"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightBlue
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Button2.Location = New System.Drawing.Point(0, 81)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(234, 50)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Items"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(0, -6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 502)
        Me.Panel1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Martina", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(316, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Available Items:"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1010, 491)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AvailableItemsListBox)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "EasyRent | Items"
        CType(Me.ItemImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ItemImage As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents RentButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AvailableItemsListBox As ListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ItemPrice As Label
    Friend WithEvents ItemName As Label
    Friend WithEvents Label3 As Label
End Class
