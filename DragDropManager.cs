using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Jukebox
{
    public class DragDropManager 
    {
        private Form m_parent;          // reference to owner form
        private delegate void DelegateOpenFiles(Array a);           // type
        private DelegateOpenFiles m_DelegateOpenFiles;              // instance

        private void OnDragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void OnDragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            try
            {
                Array a = (Array)e.Data.GetData(DataFormats.FileDrop);

                if (a != null)
                {
                    // Call owner's OpenFiles asynchronously.

                    m_parent.BeginInvoke(m_DelegateOpenFiles, new Object[] { a });

                    m_parent.Activate();        // in the case Explorer overlaps owner form
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Error in DragDropManager.OnDragDrop function: " + ex.Message);
            }
        }

        public Form Parent
        {
            set
            {
                m_parent = value;               // keep reference to owner form

                // Check if owner form implements IDropFileTarget interface
                if (!(m_parent is IDropFileTarget))
                {
                    throw new Exception(
                        "DragDropManager: Parent form doesn't implement IDropFileTarget interface");
                }

                // create delegate used for asynchronous call
                m_DelegateOpenFiles = new DelegateOpenFiles(((IDropFileTarget)m_parent).OpenFiles);

                // ensure that owner form allows dropping
                m_parent.AllowDrop = true;

                // subscribe to owner form's drag-drop events
                m_parent.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
                m_parent.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
            }
        }
    }
}
