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
        Me.lblWholesaleCost = New System.Windows.Forms.Label()
        Me.txtWholesaleCost = New System.Windows.Forms.TextBox()
        Me.lblMarkup = New System.Windows.Forms.Label()
        Me.txtMarkup = New System.Windows.Forms.TextBox()
        Me.lblRetailPrice = New System.Windows.Forms.Label()
        Me.lblRetailPriceVal = New System.Windows.Forms.Label()
        Me.btnGetRetail = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWholesaleCost
        '
        Me.lblWholesaleCost.AutoSize = True
        Me.lblWholesaleCost.Location = New System.Drawing.Point(24, 35)
        Me.lblWholesaleCost.Name = "lblWholesaleCost"
        Me.lblWholesaleCost.Size = New System.Drawing.Size(116, 13)
        Me.lblWholesaleCost.TabIndex = 0
        Me.lblWholesaleCost.Text = "Wholesale Cost of Item"
        '
        'txtWholesaleCost
        '
        Me.txtWholesaleCost.Location = New System.Drawing.Point(178, 35)
        Me.txtWholesaleCost.Name = "txtWholesaleCost"
        Me.txtWholesaleCost.Size = New System.Drawing.Size(72, 20)
        Me.txtWholesaleCost.TabIndex = 1
        '
        'lblMarkup
        '
        Me.lblMarkup.AutoSize = True
        Me.lblMarkup.Location = New System.Drawing.Point(86, 71)
        Me.lblMarkup.Name = "lblMarkup"
        Me.lblMarkup.Size = New System.Drawing.Size(54, 13)
        Me.lblMarkup.TabIndex = 2
        Me.lblMarkup.Text = "Markup %"
        '
        'txtMarkup
        '
        Me.txtMarkup.Location = New System.Drawing.Point(178, 71)
        Me.txtMarkup.Name = "txtMarkup"
        Me.txtMarkup.Size = New System.Drawing.Size(72, 20)
        Me.txtMarkup.TabIndex = 3
        '
        'lblRetailPrice
        '
        Me.lblRetailPrice.AutoSize = True
        Me.lblRetailPrice.Location = New System.Drawing.Point(79, 110)
        Me.lblRetailPrice.Name = "lblRetailPrice"
        Me.lblRetailPrice.Size = New System.Drawing.Size(61, 13)
        Me.lblRetailPrice.TabIndex = 4
        Me.lblRetailPrice.Text = "Retail Price"
        '
        'lblRetailPriceVal
        '
        Me.lblRetailPriceVal.AutoSize = True
        Me.lblRetailPriceVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRetailPriceVal.Location = New System.Drawing.Point(178, 110)
        Me.lblRetailPriceVal.Name = "lblRetailPriceVal"
        Me.lblRetailPriceVal.Padding = New System.Windows.Forms.Padding(0, 0, 70, 0)
        Me.lblRetailPriceVal.Size = New System.Drawing.Size(72, 15)
        Me.lblRetailPriceVal.TabIndex = 5
        '
        'btnGetRetail
        '
        Me.btnGetRetail.Location = New System.Drawing.Point(82, 180)
        Me.btnGetRetail.Name = "btnGetRetail"
        Me.btnGetRetail.Size = New System.Drawing.Size(75, 23)
        Me.btnGetRetail.TabIndex = 6
        Me.btnGetRetail.Text = "Get Retail"
        Me.btnGetRetail.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(175, 180)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGetRetail)
        Me.Controls.Add(Me.lblRetailPriceVal)
        Me.Controls.Add(Me.lblRetailPrice)
        Me.Controls.Add(Me.txtMarkup)
        Me.Controls.Add(Me.lblMarkup)
        Me.Controls.Add(Me.txtWholesaleCost)
        Me.Controls.Add(Me.lblWholesaleCost)
        Me.Name = "Form1"
        Me.Text = "Retail Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWholesaleCost As Label
    Friend WithEvents txtWholesaleCost As TextBox
    Friend WithEvents lblMarkup As Label
    Friend WithEvents txtMarkup As TextBox
    Friend WithEvents lblRetailPrice As Label
    Friend WithEvents lblRetailPriceVal As Label
    Friend WithEvents btnGetRetail As Button
    Friend WithEvents btnExit As Button
End Class
