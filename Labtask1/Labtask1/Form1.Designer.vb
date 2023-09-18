<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculator))
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.Button35 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button34 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.Button32 = New System.Windows.Forms.Button()
        Me.Button33 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.NewToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(114, 26)
        Me.NewToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem1
        '
        Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
        Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(114, 26)
        Me.NewToolStripMenuItem1.Text = "New"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(114, 26)
        Me.ToolStripMenuItem2.Text = "Exit"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(453, 28)
        Me.MenuStrip2.TabIndex = 21
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'Button35
        '
        Me.Button35.Location = New System.Drawing.Point(257, 326)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(56, 56)
        Me.Button35.TabIndex = 40
        Me.Button35.Text = "/"
        Me.Button35.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(195, 140)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 56)
        Me.Button3.TabIndex = 39
        Me.Button3.Text = "9"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.Location = New System.Drawing.Point(195, 202)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(56, 56)
        Me.Button24.TabIndex = 38
        Me.Button24.Text = "6"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button34
        '
        Me.Button34.Location = New System.Drawing.Point(195, 264)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(56, 56)
        Me.Button34.TabIndex = 37
        Me.Button34.Text = "3"
        Me.Button34.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(71, 93)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(304, 41)
        Me.TextBox1.TabIndex = 36
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button30
        '
        Me.Button30.Location = New System.Drawing.Point(132, 140)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(56, 56)
        Me.Button30.TabIndex = 35
        Me.Button30.Text = "8"
        Me.Button30.UseVisualStyleBackColor = True
        '
        'Button31
        '
        Me.Button31.Location = New System.Drawing.Point(257, 140)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(56, 56)
        Me.Button31.TabIndex = 34
        Me.Button31.Text = "*"
        Me.Button31.UseVisualStyleBackColor = True
        '
        'Button32
        '
        Me.Button32.Location = New System.Drawing.Point(319, 140)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(56, 56)
        Me.Button32.TabIndex = 33
        Me.Button32.Text = "CE"
        Me.Button32.UseVisualStyleBackColor = True
        '
        'Button33
        '
        Me.Button33.Location = New System.Drawing.Point(70, 140)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(56, 56)
        Me.Button33.TabIndex = 32
        Me.Button33.Text = "7"
        Me.Button33.UseVisualStyleBackColor = True
        '
        'Button26
        '
        Me.Button26.Location = New System.Drawing.Point(132, 202)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(56, 56)
        Me.Button26.TabIndex = 31
        Me.Button26.Text = "5"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'Button27
        '
        Me.Button27.Location = New System.Drawing.Point(257, 202)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(56, 56)
        Me.Button27.TabIndex = 30
        Me.Button27.Text = "+"
        Me.Button27.UseVisualStyleBackColor = True
        '
        'Button28
        '
        Me.Button28.Location = New System.Drawing.Point(319, 202)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(56, 56)
        Me.Button28.TabIndex = 29
        Me.Button28.Text = "C"
        Me.Button28.UseVisualStyleBackColor = True
        '
        'Button29
        '
        Me.Button29.Location = New System.Drawing.Point(70, 202)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(56, 56)
        Me.Button29.TabIndex = 28
        Me.Button29.Text = "4"
        Me.Button29.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.Location = New System.Drawing.Point(132, 264)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(56, 56)
        Me.Button22.TabIndex = 27
        Me.Button22.Text = "2"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.Location = New System.Drawing.Point(257, 264)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(56, 56)
        Me.Button23.TabIndex = 26
        Me.Button23.Text = "-"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button25
        '
        Me.Button25.Location = New System.Drawing.Point(70, 264)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(56, 56)
        Me.Button25.TabIndex = 25
        Me.Button25.Text = "1"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.Location = New System.Drawing.Point(70, 326)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(118, 56)
        Me.Button21.TabIndex = 24
        Me.Button21.Text = "0"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(195, 326)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(56, 56)
        Me.Button20.TabIndex = 23
        Me.Button20.Text = "."
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(319, 264)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(56, 118)
        Me.Button12.TabIndex = 22
        Me.Button12.Text = "="
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Calculator
        '
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(453, 432)
        Me.Controls.Add(Me.Button35)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.Button34)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button30)
        Me.Controls.Add(Me.Button31)
        Me.Controls.Add(Me.Button32)
        Me.Controls.Add(Me.Button33)
        Me.Controls.Add(Me.Button26)
        Me.Controls.Add(Me.Button27)
        Me.Controls.Add(Me.Button28)
        Me.Controls.Add(Me.Button29)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Button23)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Name = "Calculator"
        Me.Tag = "Calculayo"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonOne As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents Button35 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents Button34 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button30 As Button
    Friend WithEvents Button31 As Button
    Friend WithEvents Button32 As Button
    Friend WithEvents Button33 As Button
    Friend WithEvents Button26 As Button
    Friend WithEvents Button27 As Button
    Friend WithEvents Button28 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents Button25 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button12 As Button
End Class
