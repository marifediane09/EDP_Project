﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminCategories
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminCategories))
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.logoutBtn = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.catId = New System.Windows.Forms.TextBox()
        Me.addCatBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.catName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.updateCat = New System.Windows.Forms.Button()
        Me.deleteCat = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel11.Location = New System.Drawing.Point(11, 101)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(14, 50)
        Me.Panel11.TabIndex = 19
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel3.Location = New System.Drawing.Point(11, 157)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(14, 50)
        Me.Panel3.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Martina", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(389, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 42)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Categories"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(232, -6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(778, 44)
        Me.Panel2.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(606, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 26)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Logged in as admin"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.logoutBtn)
        Me.Panel1.Controls.Add(Me.Panel11)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.Button1)
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
        Me.Panel1.TabIndex = 23
        '
        'logoutBtn
        '
        Me.logoutBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.logoutBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.logoutBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.logoutBtn.Location = New System.Drawing.Point(42, 437)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(152, 47)
        Me.logoutBtn.TabIndex = 55
        Me.logoutBtn.Text = "Logout"
        Me.logoutBtn.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightBlue
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button6.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Button6.Location = New System.Drawing.Point(-1, 101)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(234, 50)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Dashboard"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel10.Location = New System.Drawing.Point(11, 381)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(14, 50)
        Me.Panel10.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Button1.Location = New System.Drawing.Point(-1, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(234, 50)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Backup"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel6.Location = New System.Drawing.Point(11, 325)
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
        Me.Button4.Location = New System.Drawing.Point(-1, 325)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(234, 50)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Users"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel5.Location = New System.Drawing.Point(11, 269)
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
        Me.Button5.Location = New System.Drawing.Point(-1, 269)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(234, 50)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Orders"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel4.Location = New System.Drawing.Point(11, 213)
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
        Me.Button3.Location = New System.Drawing.Point(-1, 213)
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
        Me.Label2.Location = New System.Drawing.Point(42, 26)
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
        Me.Button2.Location = New System.Drawing.Point(-1, 157)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(234, 50)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Items"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(297, 112)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 29
        Me.DataGridView2.Size = New System.Drawing.Size(327, 314)
        Me.DataGridView2.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(691, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 26)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Category ID:"
        '
        'catId
        '
        Me.catId.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.catId.Location = New System.Drawing.Point(801, 224)
        Me.catId.Name = "catId"
        Me.catId.Size = New System.Drawing.Size(165, 27)
        Me.catId.TabIndex = 52
        '
        'addCatBtn
        '
        Me.addCatBtn.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.addCatBtn.Location = New System.Drawing.Point(801, 320)
        Me.addCatBtn.Name = "addCatBtn"
        Me.addCatBtn.Size = New System.Drawing.Size(165, 39)
        Me.addCatBtn.TabIndex = 51
        Me.addCatBtn.Text = "Add"
        Me.addCatBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(661, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 26)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Category Name:"
        '
        'catName
        '
        Me.catName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.catName.Location = New System.Drawing.Point(801, 264)
        Me.catName.Name = "catName"
        Me.catName.Size = New System.Drawing.Size(165, 27)
        Me.catName.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Martina", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(771, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 42)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Add Category"
        '
        'updateCat
        '
        Me.updateCat.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.updateCat.Location = New System.Drawing.Point(297, 446)
        Me.updateCat.Name = "updateCat"
        Me.updateCat.Size = New System.Drawing.Size(108, 33)
        Me.updateCat.TabIndex = 55
        Me.updateCat.Text = "Update"
        Me.updateCat.UseVisualStyleBackColor = True
        '
        'deleteCat
        '
        Me.deleteCat.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.deleteCat.Location = New System.Drawing.Point(516, 446)
        Me.deleteCat.Name = "deleteCat"
        Me.deleteCat.Size = New System.Drawing.Size(108, 33)
        Me.deleteCat.TabIndex = 56
        Me.deleteCat.Text = "Delete"
        Me.deleteCat.UseVisualStyleBackColor = True
        '
        'AdminCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1010, 491)
        Me.Controls.Add(Me.deleteCat)
        Me.Controls.Add(Me.updateCat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.catId)
        Me.Controls.Add(Me.addCatBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.catName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminCategories"
        Me.Text = "EasyRent | Categories"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents catId As TextBox
    Friend WithEvents addCatBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents catName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents logoutBtn As Button
    Friend WithEvents updateCat As Button
    Friend WithEvents deleteCat As Button
End Class
