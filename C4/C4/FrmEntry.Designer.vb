﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEntry))
        Me.BtnSolo = New System.Windows.Forms.Button()
        Me.BtnOnlinePlay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnInfo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnSolo
        '
        Me.BtnSolo.Location = New System.Drawing.Point(12, 12)
        Me.BtnSolo.Name = "BtnSolo"
        Me.BtnSolo.Size = New System.Drawing.Size(103, 118)
        Me.BtnSolo.TabIndex = 0
        Me.BtnSolo.Text = "Go it offline."
        Me.BtnSolo.UseVisualStyleBackColor = True
        '
        'BtnOnlinePlay
        '
        Me.BtnOnlinePlay.Location = New System.Drawing.Point(121, 12)
        Me.BtnOnlinePlay.Name = "BtnOnlinePlay"
        Me.BtnOnlinePlay.Size = New System.Drawing.Size(103, 118)
        Me.BtnOnlinePlay.TabIndex = 1
        Me.BtnOnlinePlay.Text = "Play vs. strangers"
        Me.BtnOnlinePlay.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ℵ presents... Connect 4"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnInfo
        '
        Me.BtnInfo.Location = New System.Drawing.Point(12, 159)
        Me.BtnInfo.Name = "BtnInfo"
        Me.BtnInfo.Size = New System.Drawing.Size(212, 23)
        Me.BtnInfo.TabIndex = 3
        Me.BtnInfo.Text = "Info"
        Me.BtnInfo.UseVisualStyleBackColor = True
        '
        'FrmEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 181)
        Me.Controls.Add(Me.BtnInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnOnlinePlay)
        Me.Controls.Add(Me.BtnSolo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(252, 220)
        Me.MinimumSize = New System.Drawing.Size(252, 220)
        Me.Name = "FrmEntry"
        Me.Text = "C - 4: Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSolo As System.Windows.Forms.Button
    Friend WithEvents BtnOnlinePlay As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnInfo As System.Windows.Forms.Button
End Class
