using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatrioChat
{
    public partial class NewChatForm : Form
    {
        public event Action<string, IEnumerable<string>> OnSubmit;

        public NewChatForm(IEnumerable<string> existingUsers)
        {
            InitializeComponent();
            InitParticipantsBox(existingUsers);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            var selectedParticipants = participantsBox.SelectedItems.Cast<string>();
            string chatName = chatNameInput.Text;
            OnSubmit?.Invoke(chatName, selectedParticipants);
        }

        private void InitParticipantsBox(IEnumerable<string> existingUsers)
        {
            foreach (string username in existingUsers)
            {
                participantsBox.Items.Add(username);
            }
        }

        private void participantsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
