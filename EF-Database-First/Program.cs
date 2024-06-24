namespace EF_Database_First;

internal class Program {
    static void Main(string[] args) {
        
        var _context = new TqlprsdbContext();


        var newUser = new User {
            Id = 0, Username = "ab", Password = "ab",
            Firstname = "Angelica", Lastname = "Bufano",
            IsReviewer = true, IsAdmin = true
        };

        _context.Users.Add(newUser);

        _context.SaveChanges();

        var newVendor = new Vendor {
             Code = "TQLA", Name = "TqlAtl", 
             Address = "270 Peachtree St", City = "Atlanta", 
             State = "GA", Zip = "30303"
         }; 

         _context.Vendors.Add(newVendor);
         _context.SaveChanges();
        

        var newProduct = new Product {
            PartNbr = "COMPUTER", Name = "TQL Laptop",
            Price = 500, Unit = "Each", VendorId = 4
        };

        _context.Products.Add(newProduct);
        _context.SaveChanges();

        var newRequest = new Request {
            Id = 0, Description = "I NEED A COMPUTER", Justification = "FOR WORK",
            DeliveryMode = "PICKUP", Status = "NEW", Total = 0, 
            UserId = _context.Users.Single(x => x.Username == "ab").Id
        };

        _context.Requests.Add(newRequest);
        _context.SaveChanges();

        var newRequestline1 = new Requestline {
            Id = 0, Quantity = 1, RequestId = 2, ProductId = 10
        };

        _context.Requestlines.Add(newRequestline1);

        var newRequestline2 = new Requestline {
            Id = 0, Quantity = 1, RequestId = 2, ProductId = 1
        };

        _context.Requestlines.Add(newRequestline2);
        _context.SaveChanges();

    

       /* var deleteUser = _context.Users.Find(4);

        _context.Users.Remove(deleteUser!);

        _context.SaveChanges(); */

    }
}
