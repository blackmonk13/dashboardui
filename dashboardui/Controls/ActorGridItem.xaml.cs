using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace dashboardui.Controls
{
    public sealed partial class ActorGridItem : UserControl
    {
        public Contact contact = Contact.GetNewContact();
        public static string Lorem = "Lorem ipsum dolor sit amet consectetur adipisicing elit Impedit qui quos assumenda incidunt perferendis harum earum non fugit doloremque amet voluptate dolores possimus at labore corrupti Neque suscipit! Accusantium exercitationem?";
        public ActorGridItem()
        {
            this.InitializeComponent();
            Random rt = new Random();
            List<string> tags = Lorem.Split(" ").ToList();
            List<MetadataItem> metadatas = new List<MetadataItem>();
            for (int i = 0; i < 8; i++)
            {
                metadatas.Add(new MetadataItem { Label = tags[rt.Next(0, tags.Count)] });
            }
            taglist.Items = metadatas;
        }
    }
}
