<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtIPS = New TextBox()
        txtIPK = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        Label1 = New Label()
        Label2 = New Label()
        lblPredikat = New Label()
        SuspendLayout()
        ' 
        ' txtIPS
        ' 
        txtIPS.Location = New Point(272, 178)
        txtIPS.Name = "txtIPS"
        txtIPS.Size = New Size(194, 27)
        txtIPS.TabIndex = 0
        txtIPS.Tag = ""
        ' 
        ' txtIPK
        ' 
        txtIPK.Location = New Point(272, 246)
        txtIPK.Name = "txtIPK"
        txtIPK.Size = New Size(194, 27)
        txtIPK.TabIndex = 1
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(272, 211)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(372, 211)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(94, 29)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(180, 181)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 4
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(180, 249)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 5
        Label2.Text = "IP Kumulatif"
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(327, 295)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(0, 20)
        lblPredikat.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblPredikat)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIPK)
        Controls.Add(txtIPS)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIPS As TextBox
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPredikat As Label

End Class
