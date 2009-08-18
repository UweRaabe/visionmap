using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using FogBugzNet;
using System.Configuration;

namespace FogBugzCaseTracker
{
    public partial class HoverWindow : Form
    {


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_fb.IsLoggedIn)
                updateCases(true);
        }

        private void HoverWindow_Load(object sender, EventArgs e)
        {

            SetState(new StateLoggedOff(this));

            trayIcon.ShowBalloonTip(2000);

            MoveWindowToCenter();

            loginWithPrompt();
        }


        private void HoverWindow_MouseDown(object sender, MouseEventArgs e)
        {
            startDragging(e);
        }

        private void HoverWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
                dragWindow(e);
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
                dragWindow(e);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            startDragging(e);
        }

        private void listCases_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTrackedItem();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                MainMenu.Show();
        }

        private void notifyIcon1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Visible = !Visible;
                btnShowHide.Text = Visible ? "Hide" : "Show"; // TODO: should be handled by the state classes
            }

        }

        private void btnConfigure_Click(object sender, EventArgs e)
        {
            loginWithPrompt(true);
        }

        private void HoverWindow_FormClosed(object sender, FormClosedEventArgs e)
        {

            CloseApplication();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            updateCases();
            backgroundPic.Focus();
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            _fb.ResolveCase(_fb.CaseWorkedOnNow);
            updateCases();
        }

        private void btnViewCase_Click(object sender, EventArgs e)
        {
            Process.Start(_fb.CaseEditURL(((Case)CaseDropDown.SelectedItem).ID));
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            btnShowHide.Text = Visible ? "Hide" : "Show";
        }

        private void listCases_DropDown(object sender, EventArgs e)
        {
            UpdateCasesTimer.Enabled = false;
        }

        private void listCases_DropDownClosed(object sender, EventArgs e)
        {
            UpdateCasesTimer.Enabled = true;
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            UpdateCasesTimer.Enabled = false;
        }

        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            UpdateCasesTimer.Enabled = true;
        }

        private void SetFilter()
        {
            ShowFilterDialog();


        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            Point p = new Point(Location.X + btnMain.Location.X,
                                Location.Y + btnMain.Location.Y + btnMain.Height);
            MainMenu.Show(p);
            backgroundPic.Focus();

        }

        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            SetFilter();
            backgroundPic.Focus();

        }

        private void grip_MouseDown(object sender, MouseEventArgs e)
        {
            _resizing = true;
            _gripStartX = Cursor.Position.X;
        }

        private void grip_MouseUp(object sender, MouseEventArgs e)
        {
            _resizing = false;

        }

        private void grip_MouseMove(object sender, MouseEventArgs e)
        {
            if (_resizing)
                ResizeWidth();

        }

        private void btnResolveClose_Click(object sender, EventArgs e)
        {
            _fb.ResolveCase(_fb.CaseWorkedOnNow);
            updateCases();

        }

        private void HoverWindow_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void backgroundPic_MouseDown(object sender, MouseEventArgs e)
        {
            startDragging(e);
        }

        private void backgroundPic_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
                dragWindow(e);
        }

        private void backgroundPic_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void backgroundPic_Click(object sender, EventArgs e)
        {

        }

        private void btnNewCase_Click(object sender, EventArgs e)
        {
            Process.Start(_fb.NewCaseURL);

        }

        private void menuExportExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();

        }

        private void timerRetryLogin_Tick(object sender, EventArgs e)
        {

            RetryLogin();

        }

        private void exportToFreeMindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToFreeMind();
        }

        
        private void importFromFreeMindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoImport();
            
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            _caseBeforePause = TrackedCase;
            TrackedCase = null;
            SetState(new StatePaused(this));
        }

        private void lblImBack_Click(object sender, EventArgs e)
        {
            TrackedCase = _caseBeforePause;
            SetState(new StateTrackingCase(this));
        }

    } // Class HoverWindow
}
