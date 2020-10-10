using Common;
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
        public event Action<string, IEnumerable<User>> OnSubmit;
        private IEnumerable<User> _existingUsers;

        public NewChatForm(IEnumerable<User> existingUsers)
        {
            InitializeComponent();

            _existingUsers = existingUsers;
            InitParticipantsBox(existingUsers);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            var selectedParticipantsUsernames = participantsBox.SelectedItems.Cast<string>();
            var selectedParticipants = _existingUsers.Where(user => selectedParticipantsUsernames.Contains(user.Username));
            string chatName = chatNameInput.Text;
            OnSubmit?.Invoke(chatName, selectedParticipants);
        }

        private void InitParticipantsBox(IEnumerable<User> existingUsers)
        {
            foreach (User user in existingUsers)
            {
                participantsBox.Items.Add(user.Username);
            }
        }

        private void participantsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
