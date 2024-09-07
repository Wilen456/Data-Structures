/************************************************************/
/*                                                          */
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*                                                          */
/*  Program: Unit1Prb4.cs                                   */
/*                                                          */
/*  Programmer: Griffin                                     */
/*                                                          */
/*  Purpose: Test ArrayQueueLib with simple work order      */
/*           application                                    */
/*                                                          */
/************************************************************/
using ArrayQueueLib;

namespace Unit1Prb4
{
    public class ArrayQueue
    {
        private string name;
        private int size;
        private object?[] array;
        private const int INCREMENT = 10;
        private int front;
        private int rear;

        public ArrayQueue()
        {
            name = "DefaultQueue";
            size = 0;
            array = new object[INCREMENT];
            front = 0;
            rear = 0;
        }
        public ArrayQueue(string queueName)
        {
            name = queueName;
            size = 0;
            array = new object[INCREMENT];
            front = 0;
            rear = 0;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Front
        {
            get { return front; }
        }

        public int Size
        {
            get { return size; }
        }


        public object[] List
        {
            get { return array; }
        }


        public bool Empty
        {
            get { return size == 0; }
        }


        public void Purge()
        {
            array = new object[INCREMENT]; // Reset the array
            size = 0;
            front = 0;
            rear = 0;
        }
        public int Count
        {
            get { return size; }
        }


        public void Enqueue(object data)
        {
            if (size == array.Length)
            {
                ResizeArray(); // Resize if full
            }

            array[rear] = data;
            rear = (rear + 1) % array.Length; 
            size++;

        }


        public object Dequeue()
        {
            if (Empty)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            object dequeuedData = array[front];
            array[front] = null;
            front = (front + 1) % array.Length; // Move the front forward
            size--;
            return dequeuedData;
        }
        public object Peek()
        {
            if (Empty)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return array[front]; // Return the front element without removing it
        }


        private void ResizeArray()
        {
            object[] newArray = new object[array.Length + INCREMENT];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[(front + i) % array.Length]; // Copy elements in the correct order
            }

            array = newArray;
            front = 0;
            rear = size;
        }


    }
    public partial class Unit1Prb4Form : Form
    {
        public ArrayQueue orderQueue = new ArrayQueue("Work order queue");
        public Unit1Prb4Form()
        {
            InitializeComponent();
        }

        private void newJobButton_Click(object sender, EventArgs e)
        {

            Order newOrder = new Order();
            addForm addDialog = new addForm();
            ;

            if (addDialog.ShowDialog() == DialogResult.OK)
            {
                newOrder.OrderNumber = addDialog.returnOrderNum;
                newOrder.Name = addDialog.returnName;

                orderQueue.Enqueue(newOrder);

            }

            PrintQueue();

        }
        private void releaseOrderButton_Click(object sender, EventArgs e)
        {

            if (!orderQueue.Empty)
            {
                Order releasedOrder;
                releasedOrder = (Order)orderQueue.Dequeue();
                MessageBox.Show("Order number " + releasedOrder.OrderNumber.ToString() + " for " + releasedOrder.Name + " completed.");
                PrintQueue();
            }
            else
            {
                MessageBox.Show("Work order queue is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void PrintQueue()
        {
            numTextBox.Text = orderQueue.Count.ToString();
            queueTextBox.Clear();
            object[] queueItems = orderQueue.List;

            for (int i = 0; i < orderQueue.Size; i++)
            {
                int index = (orderQueue.Front + i) % queueItems.Length;
                Order order = (Order)queueItems[index];
                if (order != null)
                {
                    queueTextBox.AppendText(order.ToString() + Environment.NewLine);
                }
            }
        }
        public class Order
        {
            private int orderNumber;
            private string name;

            public Order()
            {
                this.orderNumber = 0; this.name = "";
            }

            public int OrderNumber // Define read/write Order Number property
            {
                get
                {
                    return this.orderNumber;
                }

                set
                {
                    this.orderNumber = value;
                }
            }

            public string Name // Define read/write UserName property
            {
                get
                {
                    return this.name;
                }

                set
                {
                    this.name = value;
                }
            }
            public override string ToString()
            {
                return this.orderNumber.ToString() + ", " + this.name;
            }
        }
    }
}