// using System;
// using System.Drawing;
// using System.Windows.Forms;

// // custom delegate
// public delegate void BtnEventHandler();

// class ButtonClickEvent : Form
// {
//     // custom event
//     public event BtnEventHandler add;

//     public Program()
//     {
//         // design a button over form
//         Button btn = new Button();
//         btn.Parent = this;
//         btn.Text = "Hit me!";
//         btn.Location = new Point(100, 100);

//         // event handler is assigned to the buttonClick event
//         btn.Click += new EventHandler(onClick);
//         add += new BtnEventHandler(Initiate);

//         add();
//     }

//     // call when event is fired
//     public void Initiate()
//     {
//         Console.WriteLine("Event Initiated");
//     }

//     // call when button clicked
//     public void onClick(object sender, EventArgs e)
//     {
//         MessageBox.Show("You clicked me!");
//     }

//     public static void Main()
//     {
//         Application.Run(new Program());
//         Console.ReadKey();
//     }

// }