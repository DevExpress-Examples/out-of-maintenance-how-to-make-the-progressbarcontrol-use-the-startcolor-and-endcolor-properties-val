Imports Microsoft.VisualBasic
Imports System
Namespace ProgressBarColors
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' progressBarControl1
			' 
			Me.progressBarControl1.EditValue = 45
			Me.progressBarControl1.Location = New System.Drawing.Point(12, 12)
			Me.progressBarControl1.Name = "progressBarControl1"
			Me.progressBarControl1.Properties.EndColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(192))))), (CInt(Fix((CByte(64))))), (CInt(Fix((CByte(0))))))
			Me.progressBarControl1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
			Me.progressBarControl1.Properties.LookAndFeel.UseDefaultLookAndFeel = False
			Me.progressBarControl1.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
			Me.progressBarControl1.Properties.StartColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))))
			Me.progressBarControl1.Size = New System.Drawing.Size(237, 18)
			Me.progressBarControl1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(259, 48)
			Me.Controls.Add(Me.progressBarControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private progressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
	End Class
End Namespace

