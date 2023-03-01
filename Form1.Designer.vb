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
        Me.tbIn = New System.Windows.Forms.TextBox()
        Me.btnReverse = New System.Windows.Forms.Button()
        Me.lblOut = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbIn
        '
        Me.tbIn.Location = New System.Drawing.Point(123, 48)
        Me.tbIn.Name = "tbIn"
        Me.tbIn.Size = New System.Drawing.Size(100, 20)
        Me.tbIn.TabIndex = 0
        '
        'btnReverse
        '
        Me.btnReverse.Location = New System.Drawing.Point(134, 118)
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Size = New System.Drawing.Size(75, 23)
        Me.btnReverse.TabIndex = 1
        Me.btnReverse.Text = "Button1"
        Me.btnReverse.UseVisualStyleBackColor = True
        '
        'lblOut
        '
        Me.lblOut.AutoSize = True
        Me.lblOut.Location = New System.Drawing.Point(155, 202)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(39, 13)
        Me.lblOut.TabIndex = 2
        Me.lblOut.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 278)
        Me.Controls.Add(Me.lblOut)
        Me.Controls.Add(Me.btnReverse)
        Me.Controls.Add(Me.tbIn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbIn As TextBox
    Friend WithEvents btnReverse As Button
    Friend WithEvents lblOut As Label
End Class
