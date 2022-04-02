/*!40101 SET NAMES utf8 */;
/*!40014 SET FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET SQL_NOTES=0 */;
DROP TABLE IF EXISTS meal;
CREATE TABLE `meal` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `title` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `description` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `imageurl` text COLLATE utf8mb4_unicode_ci,
  `location` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `when` datetime NOT NULL,
  `max_reservations` int unsigned NOT NULL,
  `cost` decimal(19,4) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
INSERT INTO meal(id,title,description,imageurl,location,when,max_reservations,cost) VALUES(1,'Beaf steak',X'6a7569637920737465616b207769746820637265616d79207361756365',X'','Herlev','2021-04-20 18:00:00',7,120.5000),(4,'pasta',X'637265616d79204974616c69616e207061737461207769746820746f6d61746f205361757365',X'','Holte','2022-03-30 13:50:23',50,0.0000);