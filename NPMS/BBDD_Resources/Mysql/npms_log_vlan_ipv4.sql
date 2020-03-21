-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: localhost    Database: npms
-- ------------------------------------------------------
-- Server version	8.0.17

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `log_vlan_ipv4`
--

DROP TABLE IF EXISTS `log_vlan_ipv4`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `log_vlan_ipv4` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Action` varchar(150) DEFAULT NULL,
  `Vlan` int(11) NOT NULL,
  `Name` varchar(150) DEFAULT NULL,
  `Location` varchar(150) DEFAULT NULL,
  `Vsys/balancer/other` varchar(150) DEFAULT NULL,
  `Description` varchar(150) DEFAULT NULL,
  `Network` varchar(65) NOT NULL,
  `Initial_Range` varchar(65) DEFAULT NULL,
  `Final_Range` varchar(65) DEFAULT NULL,
  `Mask` varchar(65) DEFAULT NULL,
  `Gateway` varchar(65) DEFAULT NULL,
  `Observations` varchar(200) DEFAULT NULL,
  `Device` varchar(150) DEFAULT NULL,
  `Firewall` varchar(150) DEFAULT NULL,
  `Environment` varchar(150) DEFAULT NULL,
  `Normative` varchar(150) DEFAULT NULL,
  `Status` varchar(150) DEFAULT NULL,
  `Network_Type` varchar(150) DEFAULT NULL,
  `Equipment` varchar(150) DEFAULT NULL,
  `Classification` varchar(150) DEFAULT NULL,
  `Work_Order` varchar(150) DEFAULT NULL,
  `User` varchar(150) DEFAULT NULL,
  `Date` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Vlan_UNIQUE` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log_vlan_ipv4`
--

LOCK TABLES `log_vlan_ipv4` WRITE;
/*!40000 ALTER TABLE `log_vlan_ipv4` DISABLE KEYS */;
/*!40000 ALTER TABLE `log_vlan_ipv4` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-03-21 18:28:05
