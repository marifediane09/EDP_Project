-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: rental_db
-- ------------------------------------------------------
-- Server version	8.0.32

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Temporary view structure for view `available_items`
--

DROP TABLE IF EXISTS `available_items`;
/*!50001 DROP VIEW IF EXISTS `available_items`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `available_items` AS SELECT 
 1 AS `item_id`,
 1 AS `item_name`,
 1 AS `category_name`,
 1 AS `owner_username`,
 1 AS `price`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categories` (
  `category_id` int NOT NULL AUTO_INCREMENT,
  `category_name` varchar(50) NOT NULL,
  PRIMARY KEY (`category_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (1,'Camera'),(2,'Music'),(3,'Clothing'),(4,'Tools'),(5,'Electronics'),(6,'Wedding'),(7,'Home'),(8,'Kitchen'),(9,'Games'),(10,'Sports');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `items`
--

DROP TABLE IF EXISTS `items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `items` (
  `item_id` int NOT NULL AUTO_INCREMENT,
  `item_name` varchar(50) NOT NULL,
  `image` varchar(50) DEFAULT NULL,
  `item_desc` text,
  `category_id` int DEFAULT NULL,
  `price` decimal(10,2) NOT NULL,
  `owner_id` int DEFAULT NULL,
  `item_status` varchar(30) NOT NULL,
  PRIMARY KEY (`item_id`),
  KEY `category_id` (`category_id`),
  KEY `owner_id` (`owner_id`),
  CONSTRAINT `items_ibfk_1` FOREIGN KEY (`category_id`) REFERENCES `categories` (`category_id`),
  CONSTRAINT `items_ibfk_2` FOREIGN KEY (`owner_id`) REFERENCES `users` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `items`
--

LOCK TABLES `items` WRITE;
/*!40000 ALTER TABLE `items` DISABLE KEYS */;
INSERT INTO `items` VALUES (1,'Barong','barong.jpg','For weddings and graduation',3,200.50,1,'available'),(2,'Alampay','alampay.jpg','For graduation',3,150.20,2,'available'),(3,'Laptop','laptop1.jpg','For students',5,350.25,1,'available'),(4,'Hair Straightener','hair.jpg','Good quality, brand new',7,100.00,4,'available'),(5,'Xylophone','xylo.jpg','Used but good',2,100.10,3,'available'),(6,'Drum','drum.jpg','3 years but still sound good',2,100.75,2,'available'),(7,'Keyboard','keyboard.jpg','Good and functional keyboard for IT',5,200.65,8,'available'),(8,'Guitar','guitar1.jpg','Rock and roll',2,300.00,9,'available'),(9,'Camera','camera.jpg','Good for memoery keeping',5,500.75,5,'available'),(10,'Roller Skates','roller.jpg','Used but still good',10,700.45,6,'available');
/*!40000 ALTER TABLE `items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payment` (
  `payment_id` int NOT NULL AUTO_INCREMENT,
  `rental_id` int NOT NULL,
  `renter_id` int NOT NULL,
  `owner_id` int NOT NULL,
  `payment_date` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `amount` decimal(10,2) NOT NULL,
  PRIMARY KEY (`payment_id`),
  KEY `renter_id` (`renter_id`),
  KEY `owner_id` (`owner_id`),
  KEY `rental_id` (`rental_id`),
  CONSTRAINT `payment_ibfk_1` FOREIGN KEY (`renter_id`) REFERENCES `users` (`user_id`),
  CONSTRAINT `payment_ibfk_2` FOREIGN KEY (`owner_id`) REFERENCES `users` (`user_id`),
  CONSTRAINT `payment_ibfk_3` FOREIGN KEY (`rental_id`) REFERENCES `rentals` (`rental_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment`
--

LOCK TABLES `payment` WRITE;
/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
INSERT INTO `payment` VALUES (1,10,7,2,'2023-04-11 09:07:04',200.50),(2,9,8,1,'2023-04-11 09:07:04',100.00),(3,8,10,9,'2023-04-11 09:07:04',150.25),(4,7,9,10,'2023-04-11 09:07:04',200.25),(5,6,2,3,'2023-04-11 09:07:04',350.25),(6,5,1,5,'2023-04-11 09:07:04',100.10),(7,4,4,6,'2023-04-11 09:07:04',200.50),(8,3,3,7,'2023-04-11 09:07:04',200.00),(9,2,6,4,'2023-04-11 09:07:04',100.25),(10,1,5,8,'2023-04-11 09:07:04',300.00);
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `payment_summary`
--

DROP TABLE IF EXISTS `payment_summary`;
/*!50001 DROP VIEW IF EXISTS `payment_summary`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `payment_summary` AS SELECT 
 1 AS `payment_id`,
 1 AS `rental_id`,
 1 AS `renter_name`,
 1 AS `owner_name`,
 1 AS `payment_date`,
 1 AS `amount`,
 1 AS `status`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `rentals`
--

DROP TABLE IF EXISTS `rentals`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rentals` (
  `rental_id` int NOT NULL AUTO_INCREMENT,
  `renter_id` int DEFAULT NULL,
  `item_id` int NOT NULL,
  `owner_id` int DEFAULT NULL,
  `rental_date` date DEFAULT NULL,
  `return_date` date DEFAULT NULL,
  `price_payable` decimal(10,2) DEFAULT NULL,
  `rental_status` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`rental_id`),
  KEY `item_id` (`item_id`),
  KEY `owner_id` (`owner_id`),
  KEY `renter_id` (`renter_id`),
  CONSTRAINT `rentals_ibfk_1` FOREIGN KEY (`item_id`) REFERENCES `items` (`item_id`),
  CONSTRAINT `rentals_ibfk_2` FOREIGN KEY (`owner_id`) REFERENCES `users` (`user_id`),
  CONSTRAINT `rentals_ibfk_3` FOREIGN KEY (`renter_id`) REFERENCES `users` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rentals`
--

LOCK TABLES `rentals` WRITE;
/*!40000 ALTER TABLE `rentals` DISABLE KEYS */;
INSERT INTO `rentals` VALUES (1,1,2,3,'2023-01-01','2023-03-02',150.20,'active'),(2,2,1,3,'2023-01-15','2023-03-01',200.50,'completed'),(3,3,5,4,'2023-01-10','2023-02-10',100.10,'active'),(4,4,6,5,'2023-01-05','2023-02-06',100.75,'active'),(5,5,7,8,'2023-01-20','2023-02-20',200.65,'active'),(6,6,9,1,'2023-01-08','2023-02-08',300.00,'active'),(7,7,10,2,'2023-01-13','2023-02-13',700.45,'active'),(8,8,3,7,'2023-01-02','2023-02-02',350.25,'active'),(9,9,4,6,'2023-01-04','2023-02-04',100.00,'active'),(10,10,8,9,'2023-01-14','2023-02-14',500.75,'completed');
/*!40000 ALTER TABLE `rentals` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `update_price_payable` BEFORE INSERT ON `rentals` FOR EACH ROW BEGIN
    DECLARE rental_days INT;
    DECLARE rental_price DECIMAL(10,2);
    
    SET rental_days = DATEDIFF(NEW.return_date, NEW.rental_date);
    SET rental_price = (SELECT price FROM items WHERE item_id = NEW.item_id);
    
    SET NEW.price_payable = rental_days * rental_price;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `update_item_status` AFTER INSERT ON `rentals` FOR EACH ROW BEGIN
    UPDATE items SET item_status = 'unavailable' WHERE item_id = NEW.item_id;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `rental_deletion` BEFORE DELETE ON `rentals` FOR EACH ROW BEGIN
    IF OLD.rental_status = 'active' THEN
        SIGNAL SQLSTATE '45000' 
        SET MESSAGE_TEXT = 'Cannot delete an active rental';
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `archive_rentals` BEFORE DELETE ON `rentals` FOR EACH ROW BEGIN
  IF OLD.rental_status = 'completed' OR OLD.rental_status = 'cancelled' THEN
    INSERT INTO rentals_archived
      (rental_id, renter_id, item_id, owner_id, rental_date, return_date, price_payable, rental_status)
    VALUES
      (OLD.rental_id, OLD.renter_id, OLD.item_id, OLD.owner_id, OLD.rental_date, OLD.return_date, OLD.price_payable, OLD.rental_status);
  END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `rentals_archived`
--

DROP TABLE IF EXISTS `rentals_archived`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rentals_archived` (
  `rental_id` int NOT NULL AUTO_INCREMENT,
  `renter_id` int NOT NULL,
  `item_id` int NOT NULL,
  `owner_id` int DEFAULT NULL,
  `rental_date` date NOT NULL,
  `return_date` date DEFAULT NULL,
  `price_payable` decimal(10,2) DEFAULT NULL,
  `rental_status` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`rental_id`),
  KEY `item_id` (`item_id`),
  KEY `owner_id` (`owner_id`),
  KEY `renter_id` (`renter_id`),
  CONSTRAINT `rentals_archived_ibfk_1` FOREIGN KEY (`item_id`) REFERENCES `items` (`item_id`),
  CONSTRAINT `rentals_archived_ibfk_2` FOREIGN KEY (`owner_id`) REFERENCES `users` (`user_id`),
  CONSTRAINT `rentals_archived_ibfk_3` FOREIGN KEY (`renter_id`) REFERENCES `users` (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rentals_archived`
--

LOCK TABLES `rentals_archived` WRITE;
/*!40000 ALTER TABLE `rentals_archived` DISABLE KEYS */;
/*!40000 ALTER TABLE `rentals_archived` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `rentals_by_renter`
--

DROP TABLE IF EXISTS `rentals_by_renter`;
/*!50001 DROP VIEW IF EXISTS `rentals_by_renter`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `rentals_by_renter` AS SELECT 
 1 AS `rental_id`,
 1 AS `username`,
 1 AS `item_name`,
 1 AS `category_name`,
 1 AS `rental_date`,
 1 AS `return_date`,
 1 AS `price_payable`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `fname` varchar(30) NOT NULL,
  `lname` varchar(30) NOT NULL,
  `username` varchar(50) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  `user_password` varchar(50) NOT NULL,
  `user_role` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'admin','EasyRent','admin','admin@gmail.com','21232f297a57a5a743894a0e4a801fc3','admin'),(2,'Ed','Sheeran','sheeraned','eds@gmail.com','4ccb00973e9cd9758bc61d2dde00f3aa','renter'),(3,'Sheena','Barnedo','sheenab','shebar@gmail.com','f35ae36195a84ae117ad7c768fdcd69a','renter'),(4,'Lea','Vuiton','vuitonl','lv@gmail.com','195ee98e844f3a2d3b521d1347a9dc55','renter'),(5,'Anya','Forger','anyaforger','anya@gmail.com','b5cf1fc4dc4ee22b7e6baff700297651','renter'),(6,'Brian','Lim','brylim','brianlim@gmail.com','19c215cba150cb693edda8d6cd1b9cb8','renter'),(7,'Morty','Lee','mlee','morty@gmail.com','5b7789c684005daa8b91ffd995c9817a','renter'),(8,'Rick','Brown','rickb','rick@gmail.com','8c156790fb962a1a876edc3f4c27fd78','renter'),(9,'Loid','Grim','loidgrim','loid@gmail.com','f49eced959fa0e3a8e7f41961bdbdbe4','renter'),(10,'Mike','Sy','msy','mikesy@gmail.com','148a90de0bb9a91d895bca4fb35496a2','renter');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `validate_email` BEFORE INSERT ON `users` FOR EACH ROW BEGIN
    IF NOT NEW.email REGEXP '^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$' THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Invalid email format';
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `available_items`
--

/*!50001 DROP VIEW IF EXISTS `available_items`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `available_items` AS select `i`.`item_id` AS `item_id`,`i`.`item_name` AS `item_name`,`c`.`category_name` AS `category_name`,`u`.`username` AS `owner_username`,`i`.`price` AS `price` from ((`items` `i` join `categories` `c` on((`i`.`category_id` = `c`.`category_id`))) join `users` `u` on((`i`.`owner_id` = `u`.`user_id`))) where (`i`.`item_status` = 'available') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `payment_summary`
--

/*!50001 DROP VIEW IF EXISTS `payment_summary`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `payment_summary` AS select `p`.`payment_id` AS `payment_id`,`p`.`rental_id` AS `rental_id`,concat(`ru`.`fname`,' ',`ru`.`lname`) AS `renter_name`,concat(`ou`.`fname`,' ',`ou`.`lname`) AS `owner_name`,`p`.`payment_date` AS `payment_date`,`p`.`amount` AS `amount`,(case when (`r`.`return_date` <= curdate()) then 'Completed' else 'Pending' end) AS `status` from ((((`payment` `p` join `rentals` `r` on((`p`.`rental_id` = `r`.`rental_id`))) join `users` `ru` on((`r`.`renter_id` = `ru`.`user_id`))) join `items` `i` on((`r`.`item_id` = `i`.`item_id`))) join `users` `ou` on((`i`.`owner_id` = `ou`.`user_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `rentals_by_renter`
--

/*!50001 DROP VIEW IF EXISTS `rentals_by_renter`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `rentals_by_renter` AS select `r`.`rental_id` AS `rental_id`,`u`.`username` AS `username`,`i`.`item_name` AS `item_name`,`c`.`category_name` AS `category_name`,`r`.`rental_date` AS `rental_date`,`r`.`return_date` AS `return_date`,`r`.`price_payable` AS `price_payable` from (((`rentals` `r` join `items` `i` on((`r`.`item_id` = `i`.`item_id`))) join `categories` `c` on((`i`.`category_id` = `c`.`category_id`))) join `users` `u` on((`r`.`renter_id` = `u`.`user_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-11 17:18:32
