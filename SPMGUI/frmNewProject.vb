Imports SMPData.SMPData
Imports SMPLibrary.SMPLibrary.Models

Public Class frmNewProject
    ' ToDo - Change controls order 

    Private myProjectHandler As New ProjectsHandler
    Private myListHandler As New ListHandler
    Private myTeam As New ProjectTeamHandler


    Private Sub frmNewProject_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' get EPC list
        myProjectHandler.FillComboBoxEPCs(cboEpc)
        myProjectHandler.FillComboBoxSubCons(cboSubcon)
        myListHandler.FillComboBox(ListNames.PROJECT_STATUS, cboStatus)
        With myTeam
            .FillComboBoxComOps(cboComOps)
            .FillComboBoxSMs(cboSales)
            .FillComboBoxPMs(cboPM)
            .FillComboBoxHMIEngs(cboHMI)
            .FillComboBoxPEs(cboPE)
            .FillComboBoxControlPEs(cboControls)
            .FillComboBoxElectPEs(cboElectrical)
            .FillComboBoxMechPEs(cboMechnical)
            .FillComboBoxDCSPEs(cboDcs)
        End With
        ' ToDo - Add logic for selecting plant
        ' ToDo - Add logic to create team

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Function ValidateForm() As Boolean
        If txtTitle.Text.Trim = "" Then
            MsgBox("Title is a must to enter !")
            txtTitle.Focus()
            Return False
        End If
        If cboStatus.SelectedItem = "" Then
            MsgBox("Status is a must to enter !")
            cboStatus.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            If ValidateForm() Then
                Dim myProject As New ProjectsModel
                With myProject
                    .Id = myProjectHandler.GetMaxId + 1
                    ' ToDo - Change this logic for plantid
                    .PlantId = 1
                    .SAPDef = txtSAPDef.Text.Trim
                    .Status = cboStatus.SelectedItem
                    .SubCon = cboSubcon.Text.Trim
                    .EPC = cboEpc.Text.Trim
                    ' ToDo - Change this logic for team id
                    .TeamId = 1000
                    .Title = txtTitle.Text.Trim
                    myProjectHandler.InsertNewRow(myProject)
                End With
                MsgBox("New Project (Id = " & myProject.Id & ") has been successfully created")
                ' ToDo - Add to log file
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class