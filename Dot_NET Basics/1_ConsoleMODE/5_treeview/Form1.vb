Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TreeView1.Nodes.Clear()
        ' Dim root = New TreeNode("DIRECTORY LIST")
        TreeView1.Nodes.Add("root")               'root node is created here
        TreeView1.Nodes(0).Nodes.Add("folder1")
        TreeView1.Nodes(0).Nodes.Add("folder2")
        TreeView1.Nodes(0).Nodes(0).Nodes.Add("subfolder1")
        TreeView1.Nodes(0).Nodes(0).Nodes.Add("subfolder2")
        'TreeView1.Nodes()

    End Sub
    End Class
