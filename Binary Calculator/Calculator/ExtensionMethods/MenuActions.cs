namespace Calculator.ExtensionMethods
{
    using System;
    using System.Windows.Forms;

    public static class MenuActions
    {
        public static void CopyAction(this RichTextBox richTextBox, object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        public static void PasteAction(this RichTextBox richTextBox, object sender, EventArgs e)
        {
            richTextBox.Paste();
        }
    }
}
