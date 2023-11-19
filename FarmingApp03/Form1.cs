using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FarmingApp03
{
    public partial class Form1 : Form
    {
        private VisualizationManager visualizationManager;

        public Form1()
        {
            InitializeComponent();

            visualizationManager = VisualizationManager.Instance;
            visualizationManager.SetVisualizationPanel(visualizationPanel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void visualizationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // If the check box is checked, expand all the tree nodes.
            if (checkBox1.Checked == true)
            {
                farmTreeView.ExpandAll();
            }
            else
            {
                // If the check box is not checked, collapse the first tree node.
                farmTreeView.CollapseAll();
            }
        }

        private void PopulateFarmBtn_Click(object sender, EventArgs e)
        {
            // Create a Crop container
            ItemContainer crop = new ItemContainer("Crop", 3000.0, 290, 210, 150, 200, 20);
            // Add the Crop container to the visualization manager
            visualizationManager.AddContainer(crop);

            // Create a Command Center container
            ItemContainer commandCenter = new ItemContainer("Command Center", 7000.0, 25, 15, 250, 100, 60);
            // Add the Command Center to the visualization manager
            visualizationManager.AddContainer(commandCenter);

            // Create a Drone item 
            Item drone = new Item("Drone", 2150.0, 105, 35, 25, 25, 5);
            // Add the Drone item to the Command Center container
            commandCenter.AddItem(drone);

            // Create a barn container
            ItemContainer barnContainer = new ItemContainer("Barn", 10000.0, 25, 210, 200, 100, 80);
            // Add the barn container to the visualization manager
            visualizationManager.AddContainer(barnContainer);

            // create a livestock container
            ItemContainer livestockContainer = new ItemContainer("Livestock Area", 5000.0, 10, 1, 100, 50, 50);
            // Add livestock container to the barn container
            barnContainer.AddItem(livestockContainer);

            // create a Milk Storage container
            ItemContainer milkStorageContainer = new ItemContainer("Milk Storage", 1000.0, 90, 55, 40, 40, 50);
            // Add Milk Storage container to the barn container
            barnContainer.AddItem(milkStorageContainer);

            // create a Cow item
            Item cow = new Item("Cow", 500.0, 5, 5, 30, 20, 15);
            // Add cow item to livestock container
            livestockContainer.AddItem(cow);


            // Display the updated structure
            visualizationManager.DisplayStructure();
        }

        private void farmTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            /*
            if (e.Node is IFormItem selectedFormItem)
            {
                // Enable UI elements for modifiction
                enableModificaitonControls();

                // Store the selected item or item container for later modification
                selectedNode = e.Node.Tag as IFormItem;
            }
            else
            {
                // Disable UI elements for modification
                disableModificationControls();

                // Clear the selected item or item container
                selectedNode = null;
            }
            */
        }

        private void enableModificationControls()
        {
            // Enable you UI elements for modification (eg. button)
        }

        private void disableModificationControls()
        {
            // Disablee your UI elements for modification (eg. button)
        }
    }
}

public interface IFormItem
{
    void AddItem(IFormItem item);
    void RemoveItem(IFormItem item);
    void Display(Control.ControlCollection controls);
    void ChangeName(string newName);
    void ChangePrice(double newPrice);
    void ChangeLocation(int newX, int newY);
    void ChangeSize(int newLength, int newWidth, int newHeight);
    void DisplayStructure(TreeNodeCollection nodes);
}


public class ItemContainer : IFormItem
{
    private List<IFormItem> items;
    private string name;
    private double price;
    private int locationX;
    private int locationY;
    private int length;
    private int width;
    private int height;

    public ItemContainer(string name, double price, int locationX, int locationY, int length, int width, int height)
    {
        this.items = new List<IFormItem>();
        this.name = name;
        this.price = price;
        this.locationX = locationX;
        this.locationY = locationY;
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public void AddItem(IFormItem item)
    {
        items.Add(item);
    }

    public void RemoveItem(IFormItem item)
    {
        items.Remove(item);
    }

    public void Display(Control.ControlCollection controls)
    {
        Panel containerPanel = new Panel
        {
            BorderStyle = BorderStyle.FixedSingle,
            Width = length,
            Height = width,
            Left = locationX,
            Top = locationY
        };

        Label nameLabel = new Label
        {
            Text = $"{name}",
            Width = 100,
            Height = 15,
            Font = new Font("Arial", 8, FontStyle.Regular),
            Left = locationX + length + 1,
            Top = locationY + width/2 +1
        };

        // Additional details can be displayed here (e.g., location, size)
        containerPanel.Controls.Add(nameLabel);

        controls.Add(containerPanel);

        containerPanel.Controls.Add(nameLabel);

        controls.Add(nameLabel);
        // Set the label to be visable
        nameLabel.Visible = true;

        foreach (var item in items)
        {
            item.Display(containerPanel.Controls);
        }
    }

    public void ChangeName(string newName)
    {
        name = newName;
    }

    public void ChangePrice(double newPrice)
    {
        price = newPrice;
    }

    public void ChangeLocation(int newX, int newY)
    {
        locationX = newX;
        locationY = newY;
    }

    public void ChangeSize(int newLength, int newWidth, int newHeight)
    {
        length = newLength;
        width = newWidth;
        height = newHeight;
    }

    public void DisplayStructure(TreeNodeCollection nodes)
    {
        TreeNode node = new TreeNode($"{name} (container)");
        DisplayDetails(node.Nodes);

        foreach (var item in items)
        {
            item.DisplayStructure(node.Nodes);
        }

        nodes.Add(node);
    }

    private void DisplayDetails(TreeNodeCollection nodes)
    {
        TreeNode node = new TreeNode($"Details: Location ({locationX}, {locationY}), Size {length}x{width}x{height}");
        nodes.Add(node);
    }
}


public class Item : IFormItem
{
    private string name;
    private double price;
    private int locationX;
    private int locationY;
    private int length;
    private int width;
    private int height;

    public Item(string name, double price, int locationX, int locationY, int length, int width, int height)
    {
        this.name = name;
        this.price = price;
        this.locationX = locationX;
        this.locationY = locationY;
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public void AddItem(IFormItem item)
    {
        // Items cannot contain other items, so this method is not applicable for Item class
        throw new InvalidOperationException("Items cannot contain other items.");
    }

    public void RemoveItem(IFormItem item)
    {
        // Items cannot contain other items, so this method is not applicable for Item class
        throw new InvalidOperationException("Items cannot contain other items.");
    }

    public void Display(Control.ControlCollection controls)
    {
        Panel itemPanel = new Panel
        {
            BorderStyle = BorderStyle.FixedSingle,
            Width = length,
            Height = width,
            Left = locationX,
            Top = locationY
        };

        Label nameLabel = new Label
        {
            Text = $"{name}",
            Width = 100,
            Height = 15,
            Font = new Font("Arial", 8, FontStyle.Regular),
            Left = locationX + length + 1,
            Top = locationY + width / 2 + 1
        };

        // Additional details can be displayed here (e.g., location, size)

        itemPanel.Controls.Add(nameLabel);

        controls.Add(itemPanel);

        itemPanel.Controls.Add(nameLabel);

        controls.Add(nameLabel);
        // Set the label to be visable
        nameLabel.Visible = true;
    }

    public void ChangeName(string newName)
    {
        name = newName;
    }

    public void ChangePrice(double newPrice)
    {
        price = newPrice;
    }

    public void ChangeLocation(int newX, int newY)
    {
        locationX = newX;
        locationY = newY;
    }

    public void ChangeSize(int newLength, int newWidth, int newHeight)
    {
        length = newLength;
        width = newWidth;
        height = newHeight;
    }

    public void DisplayStructure(TreeNodeCollection nodes)
    {
        TreeNode node = new TreeNode($"{name} (Item)");
        DisplayDetails(node.Nodes);
        nodes.Add(node);
    }

    private void DisplayDetails(TreeNodeCollection nodes)
    {
        TreeNode node = new TreeNode($"Details: Location ({locationX}, {locationY}), Size {length}x{width}x{height}");
        nodes.Add(node);
    }
}


public class VisualizationManager
{
    private static VisualizationManager instance;
    private Panel visualizationPanel;
    private List<IFormItem> formItems;

    private VisualizationManager()
    {
        formItems = new List<IFormItem>();
    }

    public static VisualizationManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new VisualizationManager();
            }
            return instance;
        }
    }

    public void SetVisualizationPanel(Panel visualizationPanel_Paint)
    {
        visualizationPanel = visualizationPanel_Paint;
    }

    public void AddContainer(IFormItem formItem)
    {
        formItems.Add(formItem);
    }

    public void DeleteContainer(IFormItem formItem)
    {
        formItems.Remove(formItem);
    }

    public void DisplayStructure()
    {
        if (visualizationPanel != null)
        {
            visualizationPanel.Controls.Clear();

            foreach (var formItem in formItems)
            {
                formItem.Display(visualizationPanel.Controls);
            }
        }
        else
        {
            // Handle the case when visualizationPanel is not set
            Console.WriteLine("Visualization panel is not set. Please set the visualization panel first.");
        }
    }

    public void DisplayStructure(TreeView treeView)
    {
        if (treeView != null)
        {
            treeView.Nodes.Clear();

            foreach (var formItem in formItems)
            {
                TreeNode parentNode = new TreeNode();
                formItem.DisplayStructure(parentNode.Nodes);
                treeView.Nodes.Add(parentNode);
            }
        }
        else
        {
            Console.WriteLine("TreeView is not set. Please set the TreeView control first.");
        }
    }

    public List<IFormItem> GetFromItems() 
    { 
        return formItems;
    }

    public void ModifyItemContainer(IFormItem itemContainer, Action<IFormItem> modification)
    {
        modification(itemContainer);
    }

    public void ModifyItem(IFormItem item, Action<IFormItem> modification)
    {
        modification(item);
    }
}
