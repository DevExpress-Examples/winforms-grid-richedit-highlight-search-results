using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace E4422 {
    public class Invoice {
        private int id;

        public int Id {
            get {
                return id;
            }
            set {
                id = value;
            }
        }

        private decimal price;

        public decimal Price {
            get {
                return price;
            }
            set {
                price = value;
            }
        }

        private string description;

        public string Description {
            get {
                return description;
            }
            set {
                description = value;
            }
        }

        public Invoice(int id, decimal price, string description) {
            this.Id = id;
            this.Price = price;
            this.Description = description;
        }
    }
}
