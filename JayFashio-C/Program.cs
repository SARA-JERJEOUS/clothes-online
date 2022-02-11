using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JayFashio_M;


namespace JayFashio_C
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (DataBase db = new DataBase())
            {

                var old = db.categor.ToList();


                List<category> m = new List<category>
               {
                   new  category{categoryname="ManH"},
                    new  category{categoryname="Manj"},
                 
                    new  category{categoryname="Mant"},
                    new  category{categoryname="womH"},
                    new  category{categoryname="womj"},
                     new  category{categoryname="womsho"},
                    new  category{categoryname="womt"},
                     new  category{categoryname="kidH"},
                    new  category{categoryname="kidt"},
                    new  category{categoryname="salary"},
            };

                foreach (var item in m)
                {
                    if (old.SingleOrDefault(r => r.categoryname == item.categoryname) == null)
                        db.categor.Add(item);
                }

                db.SaveChanges();
                /*man hoodi*/
                category a = db.categor.SingleOrDefault(x => x.categoryname == "ManH");
                var oldi = db.Items.ToList();

                List<Item> n = new List<Item>
                {
                    new Item{Name="all-over-print-mens-athletic-t-shirt-white",Color="white",Size="xl",Material="cotton",Description="all-over-white",Price=45,PathItem="~/pop/hm2.png",categoryID=a.ID},
                    new Item{Name="oversized-",Color="color",Size="xl",Material="cotton",Description="unisex-color",Price=30,PathItem="~/pop/hm3.png",categoryID=a.ID},
                    new Item{Name="oversized-white",Color="white",Size="md",Material="cotton",Description="unisex-white",Price=50,PathItem="~/pop/hm4.png",categoryID=a.ID},
                    new Item{Name="unisex-v-neck-tee-white",Color="white",Size="md",Material="cotton",Description="unisex-white",Price=60,PathItem="~/pop/hm5.png",categoryID=a.ID},
                    new Item{Name="oversized-t-shirt-classic",Color="classic",Size="xl",Material="cotton",Description="unisex-classic",Price=20,PathItem="~/pop/hm6.png",categoryID=a.ID},
                    new Item{Name="unisex-hoodie-black",Color="black",Size="md",Material="cotton",Description="unisex-black",Price=10,PathItem="~/pop/hm7.png",categoryID=a.ID},
                    new Item{Name="unisex-eco-hoodie-white",Color="white",Size="md",Material="cotton",Description="unisex-eco-hoodie-white",Price=15,PathItem="~/pop/hm8.png",categoryID=a.ID},
                    new Item{Name="unisex-french-terry-pullover-hoodie-white",Color="white",Size="md",Material="cotton",Description="unisex-white",Price=19,PathItem="~/pop/hm9.png",categoryID=a.ID},
                    new Item{Name="unisex-sueded-fleece-hoodie-black-heather",Color="black",Size="xl",Material="cotton",Description="unisex-black",Price=70,PathItem="~/pop/hm10.png",categoryID=a.ID},
                    new Item{Name="all-over-print-unisex-hoodie-white",Color="white",Size="md",Material="cotton",Description="unisex-white",Price=50,PathItem="~/pop/hm11.png",categoryID=a.ID},
                    new Item{Name="unisex-premium-hoodie-black",Color="black",Size="md",Material="cotton",Description="unisex-black",Price=13,PathItem="~/pop/hm12.png",categoryID=a.ID},
                    new Item{Name="unisex-champion-tie-dye-hoodie-black",Color="black",Size="xl",Material="cotton",Description="unisex-black",Price=14,PathItem="~/pop/hm13.png",categoryID=a.ID},
                };
                foreach (var item in n)
                {
                    if (oldi.SingleOrDefault(r => r.Name == item.Name) == null)

                        db.Items.Add(item);
                    db.SaveChanges();

                }
              /*man jackets*/
                category mj = db.categor.SingleOrDefault(x => x.categoryname == "Manj");
                

                List<Item> mj2 = new List<Item>
                {
                    new Item{Name="embroidered-champion-packable-jacket",Color="Red",Size="xl",Material="cotton",Description="Red-Jacket",Price=90,PathItem="~/pop/mj1 (1).png",categoryID =mj.ID},
                    new Item{Name="embroidered-champion-packable-jacket-light-blue",Color="blue",Size="6x",Material="cotton",Description="jacket-light-blue",Price=60,PathItem="~/pop/mj1(2).png",categoryID=mj.ID},
                    new Item{Name="mens-athleisure-jacket-black-white",Color="black",Size="md",Material="cotton",Description="jacket-black-white",Price=50,PathItem="~/pop/mj1(3).png",categoryID=mj.ID},
                    new Item{Name="mens-letterman-jacket",Color="gray",Size="md",Material="cotton",Description="jacket-gray",Price=80,PathItem="~/pop/mj1(4).png",categoryID=mj.ID},
                    new Item{Name="unisex-bomber-jacket-heather-black",Color="black",Size="xl",Material="cotton",Description="jacket-heather-black",Price=45,PathItem="~/pop/mj1(5).png",categoryID=mj.ID},
                    new Item{Name="unisex-denim-jacket-black",Color="black",Size="xl",Material="cotton",Description="jacket-black",Price=60,PathItem="~/pop/mj1(6).png",categoryID=mj.ID},
                    new Item{Name="unisex-denim-jacket-classic",Color="blue",Size="md",Material="cotton",Description="unisex-blue",Price=50,PathItem="~/pop/mj1(7).png",categoryID=mj.ID},
                   new Item{Name="unisex-denim-jacket-white",Color="white",Size="md",Material="cotton",Description="unisex-white",Price=60,PathItem="~/pop/mj8.png",categoryID=mj.ID}

                };


                foreach (var item in mj2)
                {
                    if (oldi.SingleOrDefault(r => r.Name == item.Name) == null)

                        db.Items.Add(item);
                    db.SaveChanges();

                }
                /*man t-shirt*/
                category mts = db.categor.SingleOrDefault(x => x.categoryname == "Mant");


                List<Item> mts3 = new List<Item>
                {
                    new Item{Name="all-over-print-mens-crew-neck-t-shirt-white",Color="blue",Size="xl",Material="cotton",Description="blue-Jacket",Price=90,PathItem="~/pop/mts (1).png",categoryID =mts.ID},
                    new Item{Name="all-over-print-mens-crew-neck-white",Color="white",Size="6x",Material="cotton",Description="crew-neck-white",Price=60,PathItem="~/pop/mts (2).png",categoryID=mts.ID},
                    new Item{Name="unisex-fleece-pullover-black",Color="black",Size="md",Material="cotton",Description="pullover-black",Price=50,PathItem="~/pop/mts (3).png",categoryID=mts.ID},
                    new Item{Name="unisex-staple-t-shirt-yellow",Color="yellow",Size="md",Material="cotton",Description="t-shirt-yellow",Price=80,PathItem="~/pop/mts (4).png",categoryID=mts.ID},

                };


                foreach (var item in mts3)
                {
                    if (oldi.SingleOrDefault(r => r.Name == item.Name) == null)

                        db.Items.Add(item);
                    db.SaveChanges();

                }

                /*woman hoodi*/
                category wh = db.categor.SingleOrDefault(x => x.categoryname == "womH");


                List<Item> wh1 = new List<Item>
                {
                    new Item{Name="hoodie-dress-black-front-x1",Color="black",Size="xl",Material="cotton",Description="hoodie-dress",Price=90,PathItem="~/pop/wh1.png",categoryID =wh.ID},
                    new Item{Name="premium-eco-hoodie-black",Color="black",Size="xl",Material="cotton",Description="hoodie-black",Price=60,PathItem="~/pop/wh2.png",categoryID =wh.ID},
                    new Item{Name="premium-eco-hoodie-white",Color="white",Size="xl",Material="cotton",Description="hoodie-white",Price=50,PathItem="~/pop/wh3.png",categoryID =wh.ID},
                    new Item{Name="unisex-fashion-hoodie-black",Color="black",Size="xl",Material="cotton",Description="hoodi-black",Price=90,PathItem="~/pop/wh4.png",categoryID =wh.ID},
                    new Item{Name="uunisex-eco-hoodie-black",Color="black",Size="xl",Material="cotton",Description="hoodie-black",Price=40,PathItem="~/pop/wh5.png",categoryID =wh.ID},
                    new Item{Name="unisex-essential-eco-hoodie-canyon-pink",Color="pink",Size="xl",Material="cotton",Description="hoodie-pink",Price=50,PathItem="~/pop/wh6.png",categoryID =wh.ID},     
                    new Item{Name="unisex-fashion-hoodie-black-",Color="black",Size="xl",Material="cotton",Description="hoodie-black",Price=90,PathItem="~/pop/wh7.png",categoryID =wh.ID},
                    new Item{Name="unisex-heavy-blend-hoodie-black",Color="black",Size="xl",Material="cotton",Description="hoodie-black",Price=30,PathItem="~/pop/wh8.png",categoryID =wh.ID} ,          
                    new Item{Name="unisex-kangaroo-pocket-hoodie-black",Color="black",Size="xl",Material="cotton",Description="black-hoodi",Price=90,PathItem="~/pop/wh9.png",categoryID =wh.ID},
                    new Item{Name="unisex-lightweight-hoodie-black",Color="blue",Size="xl",Material="cotton",Description="blue-Jacket",Price=50,PathItem="~/pop/wh10.png",categoryID =wh.ID},
                    new Item{Name="unisex-premium-hoodie-black",Color="black",Size="xl",Material="cotton",Description="black-hoodi",Price=80,PathItem="~/pop/wh11.png",categoryID =wh.ID},
                    new Item{Name="unisex-pullover-hoodie-black",Color="blue",Size="xl",Material="cotton",Description="blue-Jacket",Price=90,PathItem="~/pop/wh12.png",categoryID =wh.ID},
                    new Item{Name="unisex-sueded-fleece-hoodie-athletic",Color="gray",Size="xl",Material="cotton",Description="gray-Jacket",Price=80,PathItem="~/pop/wh13.png",categoryID =wh.ID},
                    new Item{Name="womens-fitted-eco-hoodie-black-pure",Color="blue",Size="xl",Material="cotton",Description="blue-Jacket",Price=20,PathItem="~/pop/wh14.png",categoryID =wh.ID},

                };


                foreach (var item in wh1)
                {
                    if (oldi.SingleOrDefault(r => r.Name == item.Name) == null)

                        db.Items.Add(item);
                    db.SaveChanges();

                }

                category wj = db.categor.SingleOrDefault(x => x.categoryname == "womj");


                List<Item> wj1 = new List<Item>
                {
                    new Item{Name="jacket  green ",Color="green",Size="xl",Material="cotton",Description="jacketgreen ",Price=90,PathItem="~/pop/wjacket.jpg",categoryID =wj.ID},
                    new Item{Name="jacket white with blue",Color="blue",Size="xl",Material="cotton",Description="jacket white",Price=60,PathItem="~/pop/wwjacket.jpg",categoryID =wj.ID},
                    new Item{Name="unisex-black",Color="brown",Size="xl",Material="cotton",Description="brown-jacket",Price=50,PathItem="~/pop/wj3.png",categoryID =wj.ID},
                    new Item{Name="unisex-jacket-black",Color="black",Size="xl",Material="cotton",Description="jacket-black",Price=90,PathItem="~/pop/wj4.png",categoryID =wj.ID},
                    new Item{Name="unisex-lightweight-zip-hoodie-charcoal-black",Color="black",Size="xl",Material="cotton",Description="jacket-black",Price=90,PathItem="~/pop/wj5.png",categoryID =wj.ID},


                };


                foreach (var item in wj1)
                {
                    if (oldi.SingleOrDefault(r => r.Name == item.Name) == null)

                        db.Items.Add(item);
                    db.SaveChanges();

                }

                category wsw = db.categor.SingleOrDefault(x => x.categoryname == "womsho");


                List<Item> wse1 = new List<Item>
                {
                    new Item{Name="unisex-eco-sweatshirt-canyon-pink ",Color="black",Size="xl",Material="cotton",Description="sweatshirt-canyon-pink ",Price=90,PathItem="~/pop/wsw (1).png",categoryID =wsw.ID},
                    new Item{Name="unisex-fleeceee-pullover-black",Color="grey",Size="xl",Material="cotton",Description="pullover-black",Price=60,PathItem="~/pop/wsw (2).png",categoryID =wsw.ID},
                    new Item{Name="unisex-french-terry-sweatshirt-black",Color="black",Size="xl",Material="cotton",Description="sweatshirt-black",Price=50,PathItem="~/pop/wsw (3).png",categoryID =wsw.ID},
                    new Item{Name="unisex-organic-sweatshirt-black",Color="black",Size="xl",Material="cotton",Description="organic-sweatshirt-black",Price=90,PathItem="~/pop/wsw (4).png",categoryID =wsw.ID},
                    new Item{Name="womens-cropped-sweatshirt-black",Color="black",Size="xl",Material="cotton",Description="cropped-sweatshirt-black",Price=90,PathItem="~/pop/wsw (5).png",categoryID =wsw.ID},


                };


                foreach (var item in wse1)
                {
                    if (oldi.SingleOrDefault(r => r.Name == item.Name) == null)

                        db.Items.Add(item);
                    db.SaveChanges();

                }


                category wst = db.categor.SingleOrDefault(x => x.categoryname == "womt");


                List<Item> wst1 = new List<Item>
                {
                    new Item{Name="unisex-denim-t-shirt-black",Color="grey",Size="xl",Material="cotton",Description="unisex-denim-t-shirt-grey",Price=90,PathItem="~/pop/tw1.png",categoryID =wst.ID},
                   new Item{Name="unisex-tri-blend-track-shirt-athletic-red ",Color="red",Size="xl",Material="cotton",Description="t-shirt-red ",Price=90,PathItem="~/pop/tw2.png",categoryID =wst.ID},
                    new Item{Name="womens-tri-blend-tee-aqua-triblend ",Color="blue",Size="xl",Material="cotton",Description="womens-tri-blend",Price=90,PathItem="~/pop/tw3.png",categoryID =wst.ID},
                   new Item{Name="oversized-tie-dye-t-shirt-navy-white ",Color="navy-white",Size="xl",Material="cotton",Description="t-shirt-navy-white",Price=90,PathItem="~/pop/tw4.png",categoryID =wst.ID},     
                    new Item{Name="unisex-staple-t-shirt ",Color="pink",Size="xl",Material="cotton",Description="t-shirt-pink ",Price=90,PathItem="~/pop/tw5.png",categoryID =wst.ID},
                   new Item{Name="loose-drop-shoulder-crop-top-black",Color="orange",Size="xl",Material="cotton",Description="loose-top-black ",Price=90,PathItem="~/pop/tw6.png",categoryID =wst.ID},
                    new Item{Name="womens-relaxed-t-shirt ",Color="pink",Size="xl",Material="cotton",Description="tpink ",Price=90,PathItem="~/pop/tw7.png",categoryID =wst.ID},
                   new Item{Name="organic-cotton-t-shirt-dress",Color="grey",Size="xl",Material="cotton",Description="grey-t-shirt ",Price=90,PathItem="~/pop/tw8.png",categoryID =wst.ID},
                    new Item{Name="unisex-34-sleeve-raglan-shirt-black-white",Color="white with green",Size="xl",Material="cotton",Description="green-t-shirt-white ",Price=90,PathItem="~/pop/tw9.png",categoryID =wst.ID},
                   new Item{Name="unisex-long-sleeve-tee ",Color="grey",Size="xl",Material="cotton",Description="grey-t-shirt ",Price=90,PathItem="~/pop/tw10.png",categoryID =wst.ID},
                   new Item{Name="unisex-jersey-t-shirt-asphalt ",Color="blackgrey",Size="xl",Material="cotton",Description="unisex-jersey-t-shirt ",Price=90,PathItem="~/pop/tw11.png",categoryID =wst.ID},
                   new Item{Name="adult-quality-tee-black ",Color="brown",Size="xl",Material="cotton",Description="brown-t-shirt",Price=90,PathItem="~/pop/tw12.png",categoryID =wst.ID},
                    new Item{Name="womens-recycled-v-neck-t-shirt",Color="black",Size="xl",Material="cotton",Description="womens-t-shirt",Price=90,PathItem="~/pop/tw13.png",categoryID =wst.ID},
                   new Item{Name="unisex-staple-t-shirt-black ",Color="black",Size="xl",Material="cotton",Description="unisex-t-shirt-black ",Price=90,PathItem="~/pop/tw14.png",categoryID =wst.ID},
                    new Item{Name="womens-crop-tee-black",Color="black",Size="xl",Material="cotton",Description="women-black",Price=90,PathItem="~/pop/tw15.png",categoryID =wst.ID}

                };


                foreach (var item in wst1)
                {
                    if (oldi.SingleOrDefault(r => r.Name == item.Name) == null)

                        db.Items.Add(item);
                    db.SaveChanges();

                }




                category tk = db.categor.SingleOrDefault(x => x.categoryname == "kidt");


                List<Item> tk1 = new List<Item>
                {
                    new Item{Name="youth-long-sleever ",Color="sleever",Size="sm",Material="cotton",Description="youth-long-sleever-age-10 ",Price=90,PathItem="~/pop/tk (1).png",categoryID =tk.ID},
                    new Item{Name="youth-long-sleeve",Color="slver",Size="sm",Material="cotton",Description="youth-long-age-5",Price=60,PathItem="~/pop/tk (2).png",categoryID =tk.ID},
                    new Item{Name="all-over-print-kids-crew-neck-t-shirt-white",Color="white",Size="sm",Material="cotton",Description="age-4",Price=50,PathItem="~/pop/tk (3).png",categoryID =tk.ID},
                    new Item{Name="youth-jersey-t-shirt-black",Color="black",Size="sm",Material="cotton",Description="youth-t-shirt-black-age-6",Price=90,PathItem="~/pop/tk (4).png",categoryID =tk.ID},


                };


                foreach (var item in tk1)
                {
                    if (oldi.SingleOrDefault(r => r.Name == item.Name) == null)

                        db.Items.Add(item);
                    db.SaveChanges();

                }

                category kh = db.categor.SingleOrDefault(x => x.categoryname == "kidH");


                List<Item> kh1 = new List<Item>
                {
                    new Item{Name="kids-hoodie-baby ",Color="sleever",Size="sm",Material="cotton",Description="kids-hoodie-baby-age-10 ",Price=90,PathItem="~/pop/hk (1).png",categoryID =kh.ID},
                    new Item{Name="kids-eco-hoodie-black",Color="orange",Size="sm",Material="cotton",Description="kids-eco-hoodie-black-age-5",Price=60,PathItem="~/pop/hk (2).png",categoryID =kh.ID},
                    new Item{Name="kids-fleece-hoodie",Color="blue",Size="sm",Material="cotton",Description="age-4",Price=50,PathItem="~/pop/hk (3).png",categoryID =kh.ID},
                    new Item{Name="baby-organic-bomber",Color="black",Size="sm",Material="cotton",Description="baby-organic-bomber-age-6",Price=90,PathItem="~/pop/hk (4).png",categoryID =kh.ID},


                };


                foreach (var item in kh1)
                {
                    if (oldi.SingleOrDefault(r => r.Name == item.Name) == null)

                        db.Items.Add(item);
                    db.SaveChanges();

                }





                category sa = db.categor.SingleOrDefault(x => x.categoryname == "salary");


                List<Item> sal = new List<Item>
                {
                    new Item{Name="unisex-bomber-jacket ",Color="black",Size="xl",Material="cotton",Description="salary ",Price=30,PathItem="~/pop/sa (1).png",categoryID =sa.ID},
                    new Item{Name="hoodie-black",Color="black",Size="xl",Material="cotton",Description="salary",Price=20,PathItem="~/pop/sa (2).png",categoryID =sa.ID},
                    new Item{Name="baby-organic-bomber-jacket",Color="black",Size="sm",Material="cotton",Description="age-4",Price=10,PathItem="~/pop/sa (3).png",categoryID =sa.ID},
                    new Item{Name="unisex-lightweight-hoodie",Color="selveer",Size="xl",Material="cotton",Description="unisex-lightweight",Price=40,PathItem="~/pop/sa (4).png",categoryID =sa.ID},

                    new Item{Name="unisex-shirt ",Color="blue",Size="xl",Material="cotton",Description="unisex-t-shirt",Price=30,PathItem="~/pop/sa (5).png",categoryID =sa.ID},
                    new Item{Name="unisex-staple-t-shirt",Color="pink",Size="xl",Material="cotton",Description="salary",Price=20,PathItem="~/pop/sa (6).png",categoryID =sa.ID},
                    new Item{Name="womens-recycled-t-shirt",Color="selver",Size="xl",Material="cotton",Description="unisex",Price=20,PathItem="~/pop/sa (7).png",categoryID =sa.ID},
                    new Item{Name="unisex-denim-jacket",Color="white",Size="xl",Material="cotton",Description="unisex-denim-jacket",Price=20,PathItem="~/pop/sa (8).png",categoryID =sa.ID},

                };


                foreach (var item in sal)
                {
                    if (oldi.SingleOrDefault(r => r.Name == item.Name) == null)

                        db.Items.Add(item);
                    db.SaveChanges();

                }

                var oldCities = db.Cities.ToList();


                List<City> ci = new List<City>
               {
                   new  City{ CityName= "alazraq" },
                   new City{ CityName = "Amman" },

                   new City{ CityName = "Irbid" },
                   new City{ CityName = "Jerash" },
                   new City{ CityName = "Almafraq" },
                   new City{ CityName = "Ajloun" },
                   new City{ CityName = "ALaqaba" },
                    new City{ CityName = "zarqa" },
            };

                foreach (var item in ci)
                {
                    if (oldCities.SingleOrDefault(r => r.CityName == item.CityName) == null)
                        db.Cities.Add(item);
                }



                db.SaveChanges();



































                //City myCity = new City();
                //myCity.Id = 1;
                /*   Image newImage = new Image();
                   newImage.Name = "Image1";
                   newImage.Height = 200;
                   newImage.Width = 200;
                   newImage.SizeMultiplier = 1;
                   newImage.PathImage = "s";
                   newImage.ItemId = 1;
                   var Images = db.Images.ToList();
                   db.Images.Add(newImage);


                
                   db.SaveChanges();*/


            }



        }
    }
}



/*
Item newItem = new Item();
                newItem.Name = "Green Hoodie"; // Since this is an Item not an Image of png
                newItem.Color = "Green";
                newItem.Size = "XL";
                newItem.Material = "Cotton";
                newItem.Description = "Very good";
                newItem.Price = 20;
                //SingleOrDefault there must be atleast one Item in db or will not work
                //db.Items.Add(newItem);
                //db.SaveChanges(); so we add these lines

                var myItems = db.Items.ToList();
                if (myItems.Any(x => x.Name == newItem.Name))
                {
                    Console.WriteLine("Already exists");
                }
                else
                {
                    Console.WriteLine("Adding it");
                    db.Items.Add(newItem);
                    db.SaveChanges();
                }

                Item i = db.Items.SingleOrDefault(o => o.Name == "Green Hoodie");
                Image newImage = new Image();
                newImage.Name = "bants"; // Since we removed the extension, we must explicity type .png/.jpg..etc
                newImage.Width = 200;
                newImage.Height = 100;
                newImage.SizeMultiplier = 1; // 55 -> Width = 200 x 55 (27,500p), Height = 100 x 55 (5,500p)
                newImage.ItemId = i.ID;

                var Images = db.Images.ToList();
                /*
                foreach (var item in Images)
                {
                    if (Images.SingleOrDefault(b => b.Name == item.Name) == null)
                    {
                        db.Images.Add(item); // We are adding the same item to the database -> we must use newImage
                        db.SaveChanges();
                    }
                }
               // &/
// New Code ->
if (Images.Any(b => b.Name == newImage.Name))
{
    Console.WriteLine("Already exists");
}
else
{
    Console.WriteLine("Adding it");
    db.Images.Add(newImage);
    db.SaveChanges();
}
*/






/*                

                /*
                Item i = db.Items.SingleOrDefault(o => o.Name == "green.jpg");
                Image m = new Image();
                m.Name = "bants";
                m.Width = 200;
                m.Height = 100;
                m.SizeMultiplier = 55;
                m.ItemId = i.ID;

                var im = db.Images.ToList();
                foreach (var item in im)
                {
                    if (im.SingleOrDefault(b => b.Name == item.Name) == null)
                    {
                        db.Images.Add(item);
                        db.SaveChanges();
                    }
                }
                */

/*
for (int i = 1; i < 4; i++)
{
    newItem.Name = "Hoodie";
    newItem.Description = "Hoodie made from " + newItem.Material;
    newItem.Color = "White";
    newItem.Material = "Cotton";
    newItem.Size = "S";
    newItem.Price = i*0.9f*5.0f;
    Items.Add(newItem);

}*/
//db.SaveChanges();

/*
var user = db.User.ToList();
foreach (var item in user)
{
    Console.WriteLine(item.FirstName + "  " + item.Location.CityName);
}
*/
/*
var x = db.Cities.SingleOrDefault(i => i.CityName == "amman");


User t = new User();
t.FirstName = "sara";
t.LastName = "jerjeous";
t.Username = "saras";
t.Password = "5562";
t.Email = "sjerjeous@gmail.com";
t.CityId = x.Id;



/*  var auth2 = db.user.SingleOrDefault(i => i.Username == "sara");
  t.Email = "jer@gmail.com";
  db.SaveChanges();*/
/*
var u = db.User.ToList();
foreach (var item in u)
{
    if (u.SingleOrDefault(r => r.Username == item.Username) == null)
    {
        db.User.Add(item);
        db.SaveChanges();
    }

}
var user = db.User.ToList();
foreach (var item in user)
{
    Console.WriteLine(item.FirstName + "  " + item.Location.CityName);
}
*/
/*
               



*/



/*            using (DataBase db = new DataBase())
            {
                /**/
/*Unhandled Exception: System.InvalidOperationException: Sequence contains more than one matching element
at System.Linq.Enumerable.SingleOrDefault[TSource](IEnumerable`1 source, Func`2 predicate)
at JayFashio_C.Program.Main(String[] args) in C:\Users\mnazz\source\repos\JayFashio-M\JayFashio-C\Program.c*/
// Errors to be fixed in the next Meeting
/*
Item newItem = new Item();
newItem.Name "Green Hoodie"; // Since this is an Item not an Image of png
newItem.Color = "Green";
newItem.Size = "XL";
newItem.Material = "Cotton";
newItem.Description = "Very good";
newItem.Price = 20;
*/
//SingleOrDefault there must be atleast one Item in db or will not work
//db.Items.Add(newItem);
//db.SaveChanges(); so we add these lines
/*
var myItems = = db.Items.ToList();
if (myItems.Any(x => x.Name == newItem.Name))
{
    Console.WriteLine("Already exists");
}
else
{
    Console.WriteLine("Adding it");
    db.Items.Add(newItem);
    db.SaveChanges();
}*/
/*
Item i = db.Items.SingleOrDefault(o => o.Name == "Green Hoodie");
Image newImage = new Image();
newImage.Name = "bants.jpg"; // Since we removed the extension, we must explicity type .png/.jpg..etc
newImage.Width = 200;
newImage.Height = 100;
newImage.SizeMultiplier = 1; // 55 -> Width = 200 x 55 (27,500p), Height = 100 x 55 (5,500p)
newImage.ItemId = i.ID;
newImage.PathImage = "~/Images/Hoodie_Slider.png";
var Images = db.Images.ToList();*/
/*
foreach (var item in Images)
{
    if (Images.SingleOrDefault(b => b.Name == item.Name) == null)
    {
        db.Images.Add(item); // We are adding the same item to the database -> we must use newImage
        db.SaveChanges();
    }
}
// */

/*
// New Code ->
if (Images.Any(b => b.Name == newImage.Name))
{
    Console.WriteLine("Already exists");
}
else
{
    Console.WriteLine("Adding it");
    db.Images.Add(newImage);
    db.SaveChanges();
}



            }
*/