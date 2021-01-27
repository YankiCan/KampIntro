--Çalıştırılacak olan kolon önce seçilmelidir! Kodun bir kısmı da seçilip çalıştırılabilir. 

--Select * from Customers - Tüm kolonları çalıştırır.
Select ContactName Adi, CompanyName Sirketadi, City Sehir from Customers 
-- seçili kolonların gösterilmesini sağlar. Arka planda fake bir tablo oluşturulur ve gösterilir. 
-- ContactName Adi yazmak, tabloyu yazdığımız 2. isimle göstermesini sağlar. 

Select * from Customers where City= 'London' -- Tek tırnak!


-- case insensitive / Büyük küçük harf fark etmez. 

sElEct * from Products where categoryId = 1 or categoryId = 3 -- İki şarttan herhangi birinin geçerli olması yeterlidir.

sElEct * from Products where categoryId = 1 and unitPrice >= 10 -- İki şartta sağlanır.


Select * from Products order by ProductName -- order by (sırala) ,Ürün ismine göre ürünleri listele (A-Z)

Select * from Products order by CategoryID -- CategoryID ye göre artarak sıralar

Select * from Products order by CategoryID, ProductName


Select * from Products where categoryID = 1 order by UnitPrice desc -- categoryID = 1 olanları filtrelere, fiyata göre sırala
-- asc (ascending): artan / desc (descending): azalan

Select count(*) from Products where CategoryID = 2 -- Tüm satırları sayılarını say (Kategori 2 de olan kaç ürün var, toplamını say)




-- Hangi kategoride kaç farklı ürün var?
Select * from products group by CategoryID -- hatalı kod, group by da seçili kolon yalnızca ona ait datalar olabilir.

Select CategoryID from Products group by CategoryID -- Bütün kategorileri tekrar etmeyecek şekilde sırala. Her bir grup için arka planda bir tablo oluşur.
Select CategoryID, count(*) from Products group by CategoryID -- Her bir grup elemanı için ayrı count hesaplanır. 


-- Ürün sayısı 10 dan az olan kategorileri listele
Select CategoryID, count(*) from Products group by CategoryID having count(*) < 10

-- Ürün sayısı 10 dan küçük olan, Unit price 20 den fazla olan 
--
-- Products where UnitPrice > 20 - Verimi filtrele (Birim fiyatı 20 den fazla olan ürünleri filtrele)
-- group by CategoryID - ye göre grupla
-- having count(*) < 10 - Filtrelenen ve gruplananlar arasından sayısı 10 dan az olanları listele
Select CategoryID, count(*) from Products where UnitPrice > 20 group by CategoryID having count(*) < 10 -- Koşul konulunca ürün sayısı azaldı, şarta uyan ürünler çıktı.


-- Neye göre birleştirilecek sorgusu on ile yapılır, id leri eşit ise getir demek, product icinde de category id diye kolon var, categories icinde de var.
-- Inner join iki tabloda da eşleşenleri bir araya getirir, eşleşmeyen dataları getirmez. 
Select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID

Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10


---DTO (Data Transformation Object)

-- od (order details) , pd (product details)
Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID


-- Hiç satış yapılmayan ürünler nelerdir? (MRsela SKT dolmak üzere)
Select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID -- Sonucun aynı çıkması bütün ürün türlerinde satış yapıldığın gösterir.

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID


-- left yazınca innerden 2 fazla görünüyor. Müşterilerde olup, siparişlerde olmayanlar.

-- Sistemimize kayıt olmuş ama bizden ürün almayan kişiler kimler? (Kampanya hazırlamak için - Sana Özel )
Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

-- right join tam tersidir

-- from Customers c - Burda ilk yazdığımız c ile tanımlamasını yapıp sonrasında da kısaltmasını kullanıyoruz.
