using MyBikesFactory.Business;
using MyBikesFactory.Business.Enums;
using MyBikesFactory.Data;


namespace MyBikesFactory.UI
{
    public partial class MainForm : Form
    {
        private List<Bikes> listOfBikes = BikesXmlData.Load();
        private Dictionary<int, int> dictionaryOfIndexes = new Dictionary<int, int>();
        private bool thereAreUnsavedChanges = false;
        private Form? previousForm = null;

        public MainForm()
        {
            InitializeComponent();
            RefreshDisplayList();
        }

        public MainForm(Form originForm) : this()
        {
            previousForm = originForm;
        }

        #region Suppport Methods
        private void ClearControls()
        {
            cbBikeType.SelectedIndex = -1;
            txtSerialNumber.Text = "";
            txtModel.Text = "";
            cbColor.SelectedIndex = -1;
            txtManufacturingYear.Text = "";
            cbSuspensionType.SelectedIndex = -1;
            cbTyreType.SelectedIndex = -1;
        }

        private int GetIndexFromDictionary()
        {
            int listBoxIndex = lstBikes.SelectedIndex;
            if (listBoxIndex < 0)
                return -1;

            return dictionaryOfIndexes[listBoxIndex];
        }
        private Bikes? FindBikeBySerialNumber(int sn)
        {
            Bikes? bikeFound = null;
            foreach (var bike in listOfBikes)
            {
                if (bike.SerialNumber == sn)
                {
                    bikeFound = bike;
                    break;
                }
            }
            return bikeFound;
        }
        private void RefreshDisplayList()
        {
            lstBikes.Items.Clear();

            dictionaryOfIndexes.Clear();


            int i = 0;
            foreach (var bike in listOfBikes)
            {
                bool include = false;

                if (rbAll.Checked)
                    include = true;
                else if (rbMountain.Checked && bike is MountainBikes)
                    include = true;
                else if (rbRoad.Checked && bike is RoadBikes)
                    include = true;

                if (include)
                {
                    dictionaryOfIndexes.Add(lstBikes.Items.Count, i);
                    lstBikes.Items.Add(bike.ToString());
                }
                i++;
            }
        }
        private bool AllFieldsAreOk()
        {
            if (cbBikeType.Text == "")
            {
                MessageBox.Show("Please select a type of bike");
                return false;
            }
            else if (txtSerialNumber.Text == "" || !Validator.ValidateId(txtSerialNumber.Text))
            {
                MessageBox.Show("Serial number is required and should contain numbers only");
                return false;
            }
            ////else if (txtModel.Text == "")
            ////{
            ////    MessageBox.Show("Please inform a model");
            ////    return false;
            ////}
            ////else if (!Validator.ValidateModel(txtModel.Text))
            ////{
            ////    MessageBox.Show("Model should contain 5 characters (numbers or letters)");
            ////    return false;
            ////}
            ////else if (cbColor.Text == "")
            ////{
            ////    MessageBox.Show("Please select color");
            ////    return false;
            ////}
            //else if (txtManufacturingYear.Text == "")
            //{
            //    MessageBox.Show("Please inform the year");
            //    return false;
            //}
            else if (!Validator.ValidateYear(txtManufacturingYear.Text))
            {
                MessageBox.Show("Year should be a number and contain 4 digits");
                return false;
            }
            ////else if (cbBikeType.Text == "Mountain" && cbSuspensionType.Text == "")
            ////{
            ////    MessageBox.Show("Please select a suspension type");
            ////    return false;
            ////}
            ////else if (cbBikeType.Text == "Road" && cbTyreType.Text == "")
            ////{
            ////    MessageBox.Show("Please select a tyre type");
            ////    return false;
            ////}
            return true;
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!AllFieldsAreOk())
                return;
            else if (!Validator.ValidateUniqueId(txtSerialNumber.Text, listOfBikes))
            {
                MessageBox.Show("This serial number is already in use");
                return;
            }

            Bikes bikeToAdd;
            if (cbBikeType.Text == "Mountain")
            {
                ESuspensionType suspensionType = (ESuspensionType)cbSuspensionType.SelectedIndex;
                bikeToAdd = new MountainBikes(suspensionType);
            }
            else
            {
                ETyreType tyreType = (ETyreType)cbTyreType.SelectedIndex;
                bikeToAdd = new RoadBikes(tyreType);
            }

            bikeToAdd.SerialNumber = Convert.ToInt32(txtSerialNumber.Text);
            bikeToAdd.Model = txtModel.Text;
            bikeToAdd.ManufacturingYear = Convert.ToInt32(txtManufacturingYear.Text);

            bikeToAdd.Color = (EColor)cbColor.SelectedIndex;

            bikeToAdd.GotInvalidNotification += Bike_GotInvalidNotification;

            if (!bikeToAdd.IsValid())
                return;

            listOfBikes.Add(bikeToAdd);

            ClearControls();

            RefreshDisplayList();

            thereAreUnsavedChanges = true;

            MessageBox.Show("The bike has been added");
        }

        private void Bike_GotInvalidNotification(string message)//this is the event handler
        {
            MessageBox.Show(message);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            BikesXmlData.Save(listOfBikes);

            thereAreUnsavedChanges = false;

            MessageBox.Show("The list of bikes has been saved");
        }

        private void cbBikeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBikeType.Text == "Mountain")
            {
                cbSuspensionType.Enabled = true;
                cbTyreType.Enabled = false;
                cbSuspensionType.SelectedIndex = -1;
                cbTyreType.SelectedIndex = -1;
            }
            else
            {
                cbSuspensionType.Enabled = false;
                cbTyreType.Enabled = true;
                cbSuspensionType.SelectedIndex = -1;
                cbTyreType.SelectedIndex = -1;
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDisplayList();
        }

        private void rbMountain_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDisplayList();
        }

        private void rbRoad_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDisplayList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSerialNumber.Text == "" || !Validator.ValidateId(txtSerialNumber.Text))
            {
                MessageBox.Show("Serial Number is required and should be numeric");
                return;
            }

            int id = Convert.ToInt32(txtSerialNumber.Text);
            var bikeFound = FindBikeBySerialNumber(id);

            if (bikeFound == null)
            {
                MessageBox.Show("Bike not found");
                return;
            }

            string message = bikeFound.ToString().Replace(",", Environment.NewLine);
            MessageBox.Show(message);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = GetIndexFromDictionary();
            if (index < 0)
            {
                MessageBox.Show("Please select a skateboard");
                return;
            }

            var result = MessageBox.Show("Do you really want to remove it?",
                                        "Confirmation",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            listOfBikes.RemoveAt(index);
            lstBikes.Items.RemoveAt(lstBikes.SelectedIndex);
            thereAreUnsavedChanges = true;

            ClearControls();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!AllFieldsAreOk())
                return;
            else if (txtSerialNumber.Text != txtOriginalSerialNumber.Text)
            {
                if (!Validator.ValidateUniqueId(txtSerialNumber.Text, listOfBikes))
                {
                    MessageBox.Show("This serial number is already used");
                    return;
                }
            }

            var bikeToUpdate = FindBikeBySerialNumber(Convert.ToInt32(txtOriginalSerialNumber.Text));

            if (bikeToUpdate is MountainBikes && cbBikeType.Text == "Road" ||
               bikeToUpdate is RoadBikes && cbBikeType.Text == "Mountain")
            {
                int listIndex = GetIndexFromDictionary();
                listOfBikes.RemoveAt(listIndex);
                if (cbBikeType.Text == "Mountain")
                    bikeToUpdate = new MountainBikes();
                else
                    bikeToUpdate = new RoadBikes();
                listOfBikes.Insert(listIndex, bikeToUpdate);
            }

            if (cbBikeType.Text == "Mountain")
            {
                (bikeToUpdate as MountainBikes)!.SuspensionType = (ESuspensionType)cbSuspensionType.SelectedIndex;
            }

            else
            {
                (bikeToUpdate as RoadBikes)!.TyreType = (ETyreType)cbTyreType.SelectedIndex;
            }

            bikeToUpdate.SerialNumber = Convert.ToInt32(txtSerialNumber.Text); ;
            bikeToUpdate.Model = txtModel.Text;
            bikeToUpdate.ManufacturingYear = Convert.ToInt32(txtManufacturingYear.Text);

            bikeToUpdate.Color = (EColor)cbColor.SelectedIndex;

            bikeToUpdate.GotInvalidNotification += Bike_GotInvalidNotification;

            if (!bikeToUpdate.IsValid())
            {
                bikeToUpdate.GotInvalidNotification -= Bike_GotInvalidNotification;
                return;
            }

            bikeToUpdate.GotInvalidNotification -= Bike_GotInvalidNotification;

            int currentSelectedIndex = lstBikes.SelectedIndex;
            RefreshDisplayList();
            lstBikes.SelectedIndex = currentSelectedIndex;

            thereAreUnsavedChanges = true;

            MessageBox.Show("The bike has been updated.");

        }

        private void lstBikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int listIndex = GetIndexFromDictionary();
            if (listIndex < 0)
                return;

            var bike = listOfBikes[listIndex];
            if (bike is MountainBikes)
            {
                cbBikeType.SelectedIndex = 0;
                var bikeAsMountain = (MountainBikes)bike;
                cbSuspensionType.SelectedIndex = (int)bikeAsMountain.SuspensionType;
            }
            else
            {
                cbBikeType.SelectedIndex = 1;
                var bikeAsRoad = (RoadBikes)bike;
                cbTyreType.SelectedIndex = (int)bikeAsRoad.TyreType;
            }

            txtSerialNumber.Text = bike.SerialNumber.ToString();
            txtOriginalSerialNumber.Text = txtSerialNumber.Text;
            txtModel.Text = bike.Model;
            cbColor.SelectedIndex = (int)bike.Color;
            txtManufacturingYear.Text = bike.ManufacturingYear.ToString();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message;
            MessageBoxIcon icon;
            if (thereAreUnsavedChanges)
            {
                message = "***THERE ARE UNSAVED CHANGES!***\n\n" +
                    "Do you really want to exit?";
                icon = MessageBoxIcon.Warning;
            }
            else
            {
                message = "Do you really want to exit?";
                icon = MessageBoxIcon.Information;
            }

            var result = MessageBox.Show(message,
                                         "Confirmation",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;//abort the process

            if (previousForm != null)
                previousForm.Show();
        }
    }
}
