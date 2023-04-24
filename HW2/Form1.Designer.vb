<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.picPayroll = New System.Windows.Forms.PictureBox()
        Me.btnTaxCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.lblFITax = New System.Windows.Forms.Label()
        Me.lblFica = New System.Windows.Forms.Label()
        Me.lblfTax = New System.Windows.Forms.Label()
        Me.lblFederal = New System.Windows.Forms.Label()
        Me.lblsTax = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblNPI = New System.Windows.Forms.Label()
        Me.lblNetIn = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblCalculation = New System.Windows.Forms.Label()
        Me.txtGross = New System.Windows.Forms.TextBox()
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPayroll
        '
        Me.picPayroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPayroll.Image = Global.HW2.My.Resources.Resources.payroll
        Me.picPayroll.Location = New System.Drawing.Point(1, 1)
        Me.picPayroll.Name = "picPayroll"
        Me.picPayroll.Size = New System.Drawing.Size(312, 194)
        Me.picPayroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPayroll.TabIndex = 0
        Me.picPayroll.TabStop = False
        '
        'btnTaxCalc
        '
        Me.btnTaxCalc.Location = New System.Drawing.Point(108, 274)
        Me.btnTaxCalc.Name = "btnTaxCalc"
        Me.btnTaxCalc.Size = New System.Drawing.Size(130, 37)
        Me.btnTaxCalc.TabIndex = 1
        Me.btnTaxCalc.Text = "Compute Taxes"
        Me.btnTaxCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(283, 274)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(130, 37)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(458, 274)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(130, 37)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Font = New System.Drawing.Font("Meiryo UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.Location = New System.Drawing.Point(209, 222)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(177, 24)
        Me.lblGrossPay.TabIndex = 4
        Me.lblGrossPay.Text = "Enter Gross Pay:"
        '
        'lblFITax
        '
        Me.lblFITax.AutoSize = True
        Me.lblFITax.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFITax.Location = New System.Drawing.Point(107, 338)
        Me.lblFITax.Name = "lblFITax"
        Me.lblFITax.Size = New System.Drawing.Size(42, 15)
        Me.lblFITax.TabIndex = 5
        Me.lblFITax.Text = "FICA:"
        '
        'lblFica
        '
        Me.lblFica.AutoSize = True
        Me.lblFica.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFica.Location = New System.Drawing.Point(163, 338)
        Me.lblFica.Name = "lblFica"
        Me.lblFica.Size = New System.Drawing.Size(0, 15)
        Me.lblFica.TabIndex = 6
        '
        'lblfTax
        '
        Me.lblfTax.AutoSize = True
        Me.lblfTax.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfTax.Location = New System.Drawing.Point(279, 338)
        Me.lblfTax.Name = "lblfTax"
        Me.lblfTax.Size = New System.Drawing.Size(86, 15)
        Me.lblfTax.TabIndex = 7
        Me.lblfTax.Text = "Federal Tax:"
        '
        'lblFederal
        '
        Me.lblFederal.AutoSize = True
        Me.lblFederal.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederal.Location = New System.Drawing.Point(378, 338)
        Me.lblFederal.Name = "lblFederal"
        Me.lblFederal.Size = New System.Drawing.Size(0, 15)
        Me.lblFederal.TabIndex = 8
        '
        'lblsTax
        '
        Me.lblsTax.AutoSize = True
        Me.lblsTax.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsTax.Location = New System.Drawing.Point(459, 338)
        Me.lblsTax.Name = "lblsTax"
        Me.lblsTax.Size = New System.Drawing.Size(72, 15)
        Me.lblsTax.TabIndex = 9
        Me.lblsTax.Text = "State Tax:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(543, 338)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(0, 15)
        Me.lblState.TabIndex = 10
        '
        'lblNPI
        '
        Me.lblNPI.AutoSize = True
        Me.lblNPI.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNPI.Location = New System.Drawing.Point(154, 395)
        Me.lblNPI.Name = "lblNPI"
        Me.lblNPI.Size = New System.Drawing.Size(199, 20)
        Me.lblNPI.TabIndex = 11
        Me.lblNPI.Text = "Net Paycheck Income:"
        '
        'lblNetIn
        '
        Me.lblNetIn.AutoSize = True
        Me.lblNetIn.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetIn.Location = New System.Drawing.Point(430, 395)
        Me.lblNetIn.Name = "lblNetIn"
        Me.lblNetIn.Size = New System.Drawing.Size(0, 20)
        Me.lblNetIn.TabIndex = 12
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Mongolian Baiti", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(316, 25)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(304, 40)
        Me.lblHeader.TabIndex = 13
        Me.lblHeader.Text = "Payroll Calculator"
        '
        'lblCalculation
        '
        Me.lblCalculation.AutoSize = True
        Me.lblCalculation.Font = New System.Drawing.Font("Mongolian Baiti", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculation.Location = New System.Drawing.Point(401, 88)
        Me.lblCalculation.Name = "lblCalculation"
        Me.lblCalculation.Size = New System.Drawing.Size(152, 58)
        Me.lblCalculation.TabIndex = 14
        Me.lblCalculation.Text = "Paycheck" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calculation"
        Me.lblCalculation.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtGross
        '
        Me.txtGross.Font = New System.Drawing.Font("Meiryo UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGross.Location = New System.Drawing.Point(420, 222)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.Size = New System.Drawing.Size(89, 32)
        Me.txtGross.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 450)
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.lblCalculation)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblNetIn)
        Me.Controls.Add(Me.lblNPI)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblsTax)
        Me.Controls.Add(Me.lblFederal)
        Me.Controls.Add(Me.lblfTax)
        Me.Controls.Add(Me.lblFica)
        Me.Controls.Add(Me.lblFITax)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTaxCalc)
        Me.Controls.Add(Me.picPayroll)
        Me.Name = "Form1"
        Me.Text = "Payroll Every Two Weeks"
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPayroll As PictureBox
    Friend WithEvents btnTaxCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents lblFITax As Label
    Friend WithEvents lblFica As Label
    Friend WithEvents lblfTax As Label
    Friend WithEvents lblFederal As Label
    Friend WithEvents lblsTax As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblNPI As Label
    Friend WithEvents lblNetIn As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblCalculation As Label
    Friend WithEvents txtGross As TextBox
End Class
