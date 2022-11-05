Imports System.Text
Imports System.Threading
Imports System.IO
Imports System.Security.Cryptography

Public Class Form1

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim outPutVal As List(Of String) = New List(Of String)
        Dim selectedRadio As String = ""
        If radDate.Checked Then
            outPutVal = ExecuteCommand("date", "")
            selectedRadio = radDate.Text
        ElseIf radTime.Checked Then
            outPutVal = ExecuteCommand("time", "")
            selectedRadio = radTime.Text
            lblNoParameters.Visible = True
        ElseIf radWhoAmI.Checked Then
            outPutVal = ExecuteCommand("whoami", "")
            selectedRadio = radWhoAmI.Text
            lblNoParameters.Visible = True
        ElseIf radWhoAmIGroup.Checked Then
            outPutVal = ExecuteCommand("whoami /groups", "")
            selectedRadio = radWhoAmIGroup.Text
            lblNoParameters.Visible = True
        ElseIf radWhoAmIUser.Checked Then
            outPutVal = ExecuteCommand("whoami /user", "")
            selectedRadio = radWhoAmIUser.Text
            lblNoParameters.Visible = True
        ElseIf radVersion.Checked Then
            outPutVal = ExecuteCommand("ver", "")
            selectedRadio = radVersion.Text
            lblNoParameters.Visible = True
        ElseIf radSystemInfo.Checked Then
            outPutVal = ExecuteCommand("systeminfo", "")
            selectedRadio = radSystemInfo.Text
            lblNoParameters.Visible = True
        ElseIf radTaskList.Checked Then
            outPutVal = ExecuteCommand("tasklist", "")
            selectedRadio = radTaskList.Text
            lblNoParameters.Visible = True
        ElseIf radTaskListSort.Checked Then
            outPutVal = ExecuteCommand("tasklist | sort", "")
            selectedRadio = radTaskListSort.Text
            lblNoParameters.Visible = True
        ElseIf radTaskSVC.Checked Then
            outPutVal = ExecuteCommand("tasklist /svc", "")
            selectedRadio = radTaskSVC.Text
            lblNoParameters.Visible = True
        ElseIf radIpConfig.Checked Then
            outPutVal = ExecuteCommand("ipconfig /all", "")
            selectedRadio = radIpConfig.Text
            lblNoParameters.Visible = True
        ElseIf radNetStat.Checked Then
            outPutVal = ExecuteCommand("netstat -ano", "")
            selectedRadio = radNetStat.Text
            lblNoParameters.Visible = True
        ElseIf radSchTasks.Checked Then
            outPutVal = ExecuteCommand("schtasks", "")
            selectedRadio = radSchTasks.Text
            lblNoParameters.Visible = True
        ElseIf radAutoruns.Checked Then
            outPutVal = ExecuteCommand("autorunsc *", "")
            selectedRadio = radAutoruns.Text
            lblNoParameters.Visible = True
        ElseIf radHandle.Checked Then
            Dim rButton As RadioButton = Handlegrp.Controls.OfType(Of RadioButton)().Where(Function(r) r.Checked = True).FirstOrDefault()
            If (rButton Is Nothing) Then
                MessageBox.Show("Please choose one Handle Parameter.")
                Return
            End If
        ElseIf radlstDLL.Checked Then
            Dim rButton As RadioButton = ListDLLgrp.Controls.OfType(Of RadioButton)().Where(Function(r) r.Checked = True).FirstOrDefault()
            If (rButton Is Nothing) Then
                MessageBox.Show("Please choose one List DLL Parameter.")
                Return
            End If
        ElseIf radProcessExplorer.Checked Then
            outPutVal = ExecuteCommand("procexp", "")
            selectedRadio = radProcessExplorer.Text
            lblNoParameters.Visible = True
        ElseIf radPsList.Checked Then
            Dim rButton As RadioButton = PsListgrp.Controls.OfType(Of RadioButton)().Where(Function(r) r.Checked = True).FirstOrDefault()
            If (rButton Is Nothing) Then
                MessageBox.Show("Please choose one PsList Parameter.")
                Return
            End If

        ElseIf radAccessCHK.Checked Then
            Dim rButton As RadioButton = AccessCHKgrp.Controls.OfType(Of RadioButton)().Where(Function(r) r.Checked = True).FirstOrDefault()
            If (rButton Is Nothing) Then
                MessageBox.Show("Please choose one Access CHK Parameter.")
                Return
            End If
        ElseIf radPsInfo.Checked Then
            Dim rButton As RadioButton = psInfogrp.Controls.OfType(Of RadioButton)().Where(Function(r) r.Checked = True).FirstOrDefault()
            If (rButton Is Nothing) Then
                MessageBox.Show("Please choose one PsInfo Parameter.")
                Return
            End If
        ElseIf radAccessEnum.Checked Then
            outPutVal = ExecuteCommand("accessenum", "")
            selectedRadio = radAccessEnum.Text
        ElseIf radShareEnum.Checked Then
            outPutVal = ExecuteCommand("shareenum", "")
            selectedRadio = radShareEnum.Text
            lblNoParameters.Visible = True
        ElseIf radTCPView.Checked Then
            Dim rButton As RadioButton = TcpViewgrp.Controls.OfType(Of RadioButton)().Where(Function(r) r.Checked = True).FirstOrDefault()
            If (rButton Is Nothing) Then
                MessageBox.Show("Please choose one TCPView Parameter.")
                Return
            End If
        ElseIf radPsFile.Checked Then
            outPutVal = ExecuteCommand("psfile \\" + txtCompName.Text + " -u " + txtUsername.Text + " -p " + txtPassword.Text + "", "")
            selectedRadio = radPsFile.Text
        End If
        If psInfoCRad.Checked And psInfoCRad.Enabled Then
            outPutVal = ExecuteCommand("psinfo \\* -c", "")
            selectedRadio = TCPViewArad.Text
        End If
        If psInfoDRad.Checked And psInfoDRad.Enabled Then
            outPutVal = ExecuteCommand("psinfo \\* -d", "")
            selectedRadio = TCPViewCrad.Text
        End If
        If psInfoHRad.Checked And psInfoHRad.Enabled Then
            outPutVal = ExecuteCommand("psinfo \\* -h", "")
            selectedRadio = TCPViewNrad.Text
        End If
        If psInfoSRad.Checked And psInfoSRad.Enabled Then
            outPutVal = ExecuteCommand("psinfo \\* -s", "")
            selectedRadio = TCPViewCrad.Text
        End If
        If psInfoTRad.Checked And psInfoTRad.Enabled Then
            outPutVal = ExecuteCommand("psinfo \\* -t", "")
            selectedRadio = TCPViewNrad.Text
        End If

        If TCPViewArad.Checked And TCPViewArad.Enabled Then
            outPutVal = ExecuteCommand("tcpview -a", "")
            selectedRadio = TCPViewArad.Text
        End If
        If TCPViewCrad.Checked And TCPViewCrad.Enabled Then
            outPutVal = ExecuteCommand("tcpview -c", "")
            selectedRadio = TCPViewCrad.Text
        End If
        If TCPViewNrad.Checked And TCPViewNrad.Enabled Then
            outPutVal = ExecuteCommand("tcpview -n", "")
            selectedRadio = TCPViewNrad.Text
        End If

        If radHandleA.Checked And radHandleA.Enabled Then
            outPutVal = ExecuteCommand("handle -a", "")
            selectedRadio = radHandle.Text
        End If
        If radHandleL.Checked And radHandleL.Enabled Then
            outPutVal = ExecuteCommand("handle -l", "")
            selectedRadio = radHandleL.Text
        End If
        If radHandleS.Checked And radHandleS.Enabled Then
            outPutVal = ExecuteCommand("handle -s", "")
            selectedRadio = radHandleS.Text
        End If
        If radHandleU.Checked And radHandleU.Enabled Then
            outPutVal = ExecuteCommand("handle -u", "")
            selectedRadio = radHandleU.Text
        End If
        If radListDLLR.Checked And radListDLLR.Enabled Then
            outPutVal = ExecuteCommand("listdlls -r", "")
            selectedRadio = radListDLLR.Text
        End If
        If radListDLLU.Checked And radListDLLU.Enabled Then
            outPutVal = ExecuteCommand("listdlls -u", "")
            selectedRadio = radListDLLU.Text
        End If
        If radListDLLV.Checked And radListDLLV.Enabled Then
            outPutVal = ExecuteCommand("listdlls -v", "")
            selectedRadio = radListDLLV.Text
        End If
        If psListEXPRad.Checked And psListEXPRad.Enabled Then
            outPutVal = ExecuteCommand("pslist exp", "")
            selectedRadio = psListEXPRad.Text
        End If
        If psListDRad.Checked And psListDRad.Enabled Then
            outPutVal = ExecuteCommand("pslist -d", "")
            selectedRadio = psListDRad.Text
        End If
        If psListMRad.Checked And psListMRad.Enabled Then
            outPutVal = ExecuteCommand("pslist -m", "")
            selectedRadio = psListMRad.Text
        End If
        If psListTrad.Checked And psListTrad.Enabled Then
            outPutVal = ExecuteCommand("pslist -t", "")
            selectedRadio = psListTrad.Text
        End If
        If psListXrad.Checked And psListXrad.Enabled Then
            outPutVal = ExecuteCommand("pslist -x", "")
            selectedRadio = psListXrad.Text
        End If
        If accessCHKDrad.Checked And accessCHKDrad.Enabled Then
            outPutVal = ExecuteCommand("accesschk -d", "")
            selectedRadio = accessCHKDrad.Text
        End If
        If accessCHKErad.Checked And accessCHKErad.Enabled Then
            outPutVal = ExecuteCommand("accesschk -e", "")
            selectedRadio = accessCHKErad.Text
        End If
        If accessCHKIrad.Checked And accessCHKIrad.Enabled Then
            outPutVal = ExecuteCommand("accesschk -i", "")
            selectedRadio = accessCHKIrad.Text
        End If
        If accessCHKNrad.Checked And accessCHKNrad.Enabled Then
            outPutVal = ExecuteCommand("accesschk -n", "")
            selectedRadio = accessCHKNrad.Text
        End If
        If accessCHKQrad.Checked And accessCHKQrad.Enabled Then
            outPutVal = ExecuteCommand("accesschk -q", "")
            selectedRadio = accessCHKQrad.Text
        End If
        If accessCHKSrad.Checked And accessCHKSrad.Enabled Then
            outPutVal = ExecuteCommand("accesschk -s", "")
            selectedRadio = accessCHKSrad.Text
        End If
        If accessCHKTrad.Checked And accessCHKTrad.Enabled Then
            outPutVal = ExecuteCommand("accesschk -t", "")
            selectedRadio = accessCHKTrad.Text
        End If
        If accessCHKWrad.Checked And accessCHKWrad.Enabled Then
            outPutVal = ExecuteCommand("accesschk -w", "")
            selectedRadio = accessCHKWrad.Text
        End If

        lblNoParameters.Visible = True
        WriteCommandOutput(("Command Name :" + selectedRadio))
        WriteCommandOutput(("Execution Time :" + DateTime.Now.ToString))
        For Each item As String In outPutVal
            richTextBox1.Text = (richTextBox1.Text _
                        + (item + "" & vbLf))
            WriteCommandOutput(item)
        Next
    End Sub

    Public Sub WriteCommandOutput(ByVal output As String)
        Dim sw As StreamWriter = File.AppendText("output.log")
        sw.WriteLine(output)
        sw.Close()
    End Sub

    Public Function ExecuteCommand(ByVal commandName As String, ByVal parameter As String) As List(Of String)
        Dim outputData As List(Of String) = New List(Of String)()

        Try
            Dim proc As ProcessStartInfo = New ProcessStartInfo("cmd.exe")
            Dim pr As Process
            proc.CreateNoWindow = True
            proc.UseShellExecute = False
            proc.RedirectStandardInput = True
            proc.RedirectStandardOutput = True
            pr = Process.Start(proc)
            pr.StandardInput.WriteLine(commandName)
            pr.StandardInput.Close()
            outputData.Add(pr.StandardOutput.ReadToEnd())
            pr.StandardOutput.Close()

        Catch
        End Try

        Return outputData
    End Function

    Private Sub radHandle_CheckedChanged(sender As Object, e As EventArgs) Handles radHandle.CheckedChanged
        If radHandle.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = True
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
            'lblNoParameters.Visible = False
        End If
    End Sub

    Private Sub radlstDLL_CheckedChanged(sender As Object, e As EventArgs) Handles radlstDLL.CheckedChanged
        If radlstDLL.Checked Then
            ListDLLgrp.Enabled = True
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
            'lblNoParameters.Visible = False
        End If
    End Sub

    Private Sub radAccessCHK_CheckedChanged(sender As Object, e As EventArgs) Handles radAccessCHK.CheckedChanged
        If radAccessCHK.Checked Then
            AccessCHKgrp.Enabled = True
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = False
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub radTCPView_CheckedChanged(sender As Object, e As EventArgs) Handles radTCPView.CheckedChanged
        If radTCPView.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = True
            lblNoParameters.Visible = False
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub radPsList_CheckedChanged(sender As Object, e As EventArgs) Handles radPsList.CheckedChanged
        If radPsList.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = True
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = False
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub radDate_CheckedChanged(sender As Object, e As EventArgs) Handles radDate.CheckedChanged
        If radDate.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = True
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub radTime_CheckedChanged(sender As Object, e As EventArgs) Handles radTime.CheckedChanged
        If radTime.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = True
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub radWhoAmI_CheckedChanged(sender As Object, e As EventArgs) Handles radWhoAmI.CheckedChanged
        If radWhoAmI.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = True
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub radWhoAmIUser_CheckedChanged(sender As Object, e As EventArgs) Handles radWhoAmIUser.CheckedChanged
        If radWhoAmIUser.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = True
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub radWhoAmIGroup_CheckedChanged(sender As Object, e As EventArgs) Handles radWhoAmIGroup.CheckedChanged
        If radWhoAmIGroup.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = True
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub radSystemInfo_CheckedChanged(sender As Object, e As EventArgs) Handles radSystemInfo.CheckedChanged
        If radSystemInfo.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = True
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub radTaskList_CheckedChanged(sender As Object, e As EventArgs) Handles radTaskList.CheckedChanged
        If radTaskList.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = True
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub radTaskListSort_CheckedChanged(sender As Object, e As EventArgs) Handles radTaskListSort.CheckedChanged
        If radTaskListSort.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = True
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub radTaskSVC_CheckedChanged(sender As Object, e As EventArgs) Handles radTaskSVC.CheckedChanged
        If radTaskSVC.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = True
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub radIpConfig_CheckedChanged(sender As Object, e As EventArgs) Handles radIpConfig.CheckedChanged
        If radIpConfig.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = True
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub radNetStat_CheckedChanged(sender As Object, e As EventArgs) Handles radNetStat.CheckedChanged
        If radNetStat.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = True
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub radSchTasks_CheckedChanged(sender As Object, e As EventArgs) Handles radSchTasks.CheckedChanged
        If radSchTasks.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = True
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub radAccessEnum_CheckedChanged(sender As Object, e As EventArgs) Handles radAccessEnum.CheckedChanged
        If radAccessEnum.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = True
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub radShareEnum_CheckedChanged(sender As Object, e As EventArgs) Handles radShareEnum.CheckedChanged
        If radShareEnum.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = True
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub radProcessExplorer_CheckedChanged(sender As Object, e As EventArgs) Handles radProcessExplorer.CheckedChanged
        If radProcessExplorer.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = True
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub radVersion_CheckedChanged(sender As Object, e As EventArgs) Handles radVersion.CheckedChanged
        If radVersion.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = True
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub radAutoruns_CheckedChanged(sender As Object, e As EventArgs) Handles radAutoruns.CheckedChanged
        If radAutoruns.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = True
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub btnChecksum_Click(sender As Object, e As EventArgs) Handles btnChecksum.Click
        Dim hash = MD5.Create()
        Dim hashValue() As Byte
        Dim fileStream As FileStream = File.OpenRead("output.log")
        fileStream.Position = 0
        hashValue = hash.ComputeHash(fileStream)
        Dim hash_hex = PrintByteArray(hashValue)
        fileStream.Close()
        MessageBox.Show(hash_hex)
    End Sub

    Public Function PrintByteArray(ByVal array() As Byte)
        Dim hex_value As String = ""
        Dim i As Integer
        For i = 0 To array.Length - 1
            hex_value += array(i).ToString("X2")
        Next i
        Return hex_value.ToLower
    End Function

    Private Sub radPsInfo_CheckedChanged(sender As Object, e As EventArgs) Handles radPsInfo.CheckedChanged
        If radPsInfo.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = False
            psInfogrp.Enabled = True
            PsFilegrp.Enabled = False
        End If
    End Sub

    Private Sub radPsFile_CheckedChanged(sender As Object, e As EventArgs) Handles radPsFile.CheckedChanged
        If radPsFile.Checked Then
            AccessCHKgrp.Enabled = False
            Handlegrp.Enabled = False
            ListDLLgrp.Enabled = False
            PsListgrp.Enabled = False
            TcpViewgrp.Enabled = False
            lblNoParameters.Visible = False
            psInfogrp.Enabled = False
            PsFilegrp.Enabled = True
        End If
    End Sub
End Class
