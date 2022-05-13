using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day5_Info {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e) {
            TreeNode node = new TreeNode(textBox1.Text);
            if(treeView1.SelectedNode != null && treeView1.SelectedNode.IsSelected) {
                treeView1.SelectedNode.Nodes.Add(node);
            } 
            else {
                treeView1.Nodes.Add(node);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e) {
            treeView1.SelectedNode.Remove();
        }

        private void BtnExpand_Click(object sender, EventArgs e) {
            treeView1.ExpandAll();
        }

        private void BtnReduce_Click(object sender, EventArgs e) {
            treeView1.CollapseAll();
        }

        List<TreeNode> chkNode = new List<TreeNode>();
        void removeCheckedNodes(TreeNodeCollection nodes) {
            if (nodes != null) {
                foreach (TreeNode node in nodes) {
                    if (node.Checked) {
                        chkNode.Add(node);
                    } else {
                        removeCheckedNodes(node.Nodes); //상위 노드가 체크되어 있지 않으면 하위 노드에서 체크된 노드 있는지 재 탐색
                    }
                }
                foreach (TreeNode chknode in chkNode) {
                    nodes.Remove(chknode);
                }
            }
        }

        private void BtnDelSel_Click(object sender, EventArgs e) {
            removeCheckedNodes(treeView1.Nodes);
        }
    }
}
