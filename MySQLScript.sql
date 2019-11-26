-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: localhost    Database: cts02
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
-- Temporary view structure for view `checktopup`
--

DROP TABLE IF EXISTS `checktopup`;
/*!50001 DROP VIEW IF EXISTS `checktopup`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `checktopup` AS SELECT 
 1 AS `ticketID`,
 1 AS `SEQ`,
 1 AS `AMOUNT`,
 1 AS `STATUS`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `CID` varchar(10) NOT NULL,
  `CFirstName` varchar(30) NOT NULL,
  `CLastName` varchar(30) NOT NULL,
  `C_SAddress` varchar(100) DEFAULT NULL,
  `C_SDistrict` varchar(30) DEFAULT NULL,
  `C_District` varchar(30) DEFAULT NULL,
  `C_Province` varchar(30) DEFAULT NULL,
  `C_PostalCode` varchar(5) DEFAULT NULL,
  `CDOB` date NOT NULL,
  `CNID` varchar(13) NOT NULL,
  `CTelNo` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`CID`),
  UNIQUE KEY `CID_UNIQUE` (`CID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES ('CR00000001','David','Tumcharoen','Engineering','Chula','Pathumwan','Bangkok','10330','1998-12-12','1100702804913','0990824222'),('CR00000002','Tester','sdfa','asdasdas','sadasd','asdsad','sadsad','59889','1968-05-06','1864481172088','0882526484'),('CR00000003','sd','sd','sd','sd','sd','sd','12324','1998-12-12','21212','12121'),('CR00000004','sd','sd','sd','sd','sd','sd','1','1998-12-12','21','1'),('CR00000005','ihgfuih','iuhiu','hiuh','iuh','iuh','iuh','41534','2004-11-16','4684864684684','6468468468'),('CR00000006','John','Doe','John St.','Bath','North London','London','55025','1968-05-29','1194842284455','0998784216'),('CR00000007','Jane','Doe','Ads','Boom','Meam','Bunch','21894','1995-06-05','1084864894521','0597930487'),('CR00000008','Kongtap','Arunlakvilart','1234/567 Supalia Aleet Surawong','4praya','banglove','krungtepmakanakorn','10500','2019-11-22','',''),('CR00000009','Kongtap','Arunlakvilart','1234/567 Supalia Aleet Surawong','4praya','banglove','krungtepmakanakorn','10500','2019-11-22','1234567891011','0854123456'),('CR00000010','asdajfh','hiohiohdsi','hoihih','hioh','ioh','ihioh','h','1995-11-16','9864531865318','8645852025'),('CR00000011','Michael ','De Santa','Rosewood','Rockstar','Trevor','Grand','55555','1964-11-01','1028414911320','0086218478'),('CR00000012','Cts','Tester','Test','T','e','st','55159','1984-11-16','1154482330084','0983487128'),('CR00000013','Melvin','Macaranas','CBA','Chula','Pathumwan','Bangkok','10330','1999-06-08','1101700265005','0820524667'),('CR00000014','i','hioh','iohi','oh','oih','oih','ioh','1998-11-16','0852896541316','8611869689'),('CR00000015','klijhui','h','uilh','ui','olh','fwef','luiho','2019-11-16','2568415321561','6546198418'),('CR00000016','iohuuil;oj','huih;h','pui;oh','o;h','ohh','hiohioh','16548','2001-11-16','1861681861681','1562068518'),('CR00000017','ihkljioj','jiojoij','iojoijoij','iojiomnio','moijno','i','61165','2019-11-16','1515618651865','2894185152'),('CR00000018','NUInuioh','oiuhknuoin','nbuinbiu','buibub','ibuibiu','b','16848','2019-11-16','1861864789781','5613251864'),('CR00000019','David','Fasdf','bgiuhio','hiohioj','uhinuin','uhhbui','51841','1998-11-16','8648653878278','1785838387'),('CR00000020','ertyuiop','fdghjkl','ertuiop','dfghjkl;','rtyuiop','fghjkl','85208','1878-11-25','0258282486518','5895984154'),('CR00000021','zxcvbnm','sdfghjkl','rtyuio','fghjkl','tyuio','vbnm,','34567','1989-11-25','3456789034567','3456734567'),('CR00000022','sdfghjkl','fdghjkl','dfghjkl','dfghjk','tfghijok','dfghjk','45678','1967-11-25','3456782142335','3456742342'),('CR00000023','awfewgwg','fewfwefewf','fwege','ertjouu','ui;ui','fdbdbf','45687','1967-11-25','5343231312378','3783885343'),('CR00000024','Prayut','Chan-O-Cha','เกียกกาย','พญาไท','นรก','กรุงเทพ','10330','1940-11-16','9999999999999','0999999999'),('CR00000025','tyfgvf','yuvyuvyu','vyuvyu','vyuv','yuv','yuvy','16548','2019-11-16','1894898418184','8480815489'),('CR00000026','ijioj','njio;n','ionoin','ion','ion','nnoin','56786','2019-11-16','7657645656846','7518454684'),('CR00000027','awdwad','wfe','rewger','gerg','ergerg','ergerg','24352','2019-11-25','5475475464365','8765865856'),('CR00000028','ewgwg','5weg','gwegwegweg','trgregerg','cvbcxbx','adwqewqr','35436','2019-11-25','1241342132131','3131313131'),('CR00000029','Steve','Steve','Bang','Asd','Street','Bangkok','10330','1998-05-16','1105563021982','0885188786'),('CR00000030','Utopia','Pizza','Gong','Meam','Distinct','Chiangmuai','55178','1978-07-30','1104889994485','0992815184'),('CR00000031','New','Card','Again','asfhioh','oihoih','oih','77746','1859-12-07','2214894784842','0990871474');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `station`
--

DROP TABLE IF EXISTS `station`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `station` (
  `SID` varchar(5) NOT NULL,
  `SName` varchar(20) NOT NULL,
  `SLatitude` float(10,6) NOT NULL,
  `SLongitude` float(10,6) NOT NULL,
  `STelNo` varchar(10) NOT NULL,
  PRIMARY KEY (`SID`),
  UNIQUE KEY `SID_UNIQUE` (`SID`),
  UNIQUE KEY `STelNo_UNIQUE` (`STelNo`),
  UNIQUE KEY `SName_UNIQUE` (`SName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `station`
--

LOCK TABLES `station` WRITE;
/*!40000 ALTER TABLE `station` DISABLE KEYS */;
INSERT INTO `station` VALUES ('ST001','Sala Prakeaw Common',13.735426,100.531830,'022188901'),('ST002','Political Science',13.734290,100.533600,'022188902'),('ST003','Engineering',13.734291,100.534302,'022188903'),('ST004','Arts',13.738865,100.534767,'022188904'),('ST005','Veterinary Science',13.742154,100.535225,'022188905'),('ST006','Chaloem Phao',13.744757,100.535645,'022188906'),('ST007','Siam',13.745759,100.532730,'022188907'),('ST008','Pharmaceutical Sci',13.743500,100.530510,'022188908'),('ST009','Architecture',13.740532,100.531998,'022188909'),('ST010','CU Office',13.739716,100.528641,'022188910'),('ST011','CU Dormitory',13.740871,100.527458,'022188911'),('ST012','Allied Health Sci',13.743470,100.527969,'022188912'),('ST013','National Stadium',13.746547,100.528442,'022188913'),('ST014','Stadium One',13.746928,100.524879,'022188914'),('ST015','Chula Phat 13',13.743872,100.524414,'022188915'),('ST016','CU iHouse',13.741373,100.525635,'022188916'),('ST017','CU Centenary Park',13.738779,100.525139,'022188917'),('ST018','Samyan Market',13.736897,100.524780,'022188918'),('ST019','Chamchuri 9',13.735620,100.525063,'022188919'),('ST020','U-Center Dormitory',13.735338,100.526939,'022188920'),('ST021','Law',13.735055,100.528717,'022188921'),('ST022','Education',13.737561,100.529335,'022188922'),('ST023','Science',13.737574,100.531693,'022188923');
/*!40000 ALTER TABLE `station` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `stationview`
--

DROP TABLE IF EXISTS `stationview`;
/*!50001 DROP VIEW IF EXISTS `stationview`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `stationview` AS SELECT 
 1 AS `SID`,
 1 AS `SName`,
 1 AS `AmountIn`,
 1 AS `AmountOut`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `ticded`
--

DROP TABLE IF EXISTS `ticded`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ticded` (
  `TicketID` varchar(10) NOT NULL,
  `TicSeq` int(11) NOT NULL,
  `Amount` int(11) NOT NULL,
  `TransacDate` date NOT NULL,
  `TransacTime` time NOT NULL,
  `SID` varchar(5) NOT NULL,
  PRIMARY KEY (`TicSeq`,`TicketID`),
  KEY `SID_idx` (`SID`),
  KEY `TicketIDFK` (`TicketID`),
  CONSTRAINT `SID` FOREIGN KEY (`SID`) REFERENCES `station` (`SID`),
  CONSTRAINT `TicketIDFK` FOREIGN KEY (`TicketID`) REFERENCES `ticket` (`TicketID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ticded`
--

LOCK TABLES `ticded` WRITE;
/*!40000 ALTER TABLE `ticded` DISABLE KEYS */;
INSERT INTO `ticded` VALUES ('TK00000001',1,17,'2019-11-25','16:07:18','ST009'),('TK00000002',1,15,'2019-11-25','14:45:50','ST007'),('TK00000003',1,15,'2019-11-25','20:53:12','ST015'),('TK00000004',1,12,'2019-11-25','20:53:28','ST008'),('TK00000005',1,19,'2019-11-25','20:53:34','ST009'),('TK00000006',1,20,'2019-11-25','16:08:43','ST009'),('TK00000007',1,11,'2019-11-25','20:53:47','ST013'),('TK00000008',1,10,'2019-11-25','20:53:56','ST018'),('TK00000009',1,15,'2019-11-25','20:54:00','ST022'),('TK00000010',1,18,'2019-11-25','20:54:05','ST023'),('TK00000011',1,20,'2019-11-25','18:04:03','ST023'),('TK00000012',1,13,'2019-11-25','20:41:34','ST013'),('TK00000013',1,17,'2019-11-25','20:54:18','ST004'),('TK00000014',1,18,'2019-11-25','20:54:22','ST005'),('TK00000015',1,11,'2019-11-25','20:54:28','ST018'),('TK00000016',1,15,'2019-11-25','20:29:12','ST006'),('TK00000017',1,18,'2019-11-25','20:52:57','ST023'),('TK00000001',2,19,'2019-11-25','16:09:03','ST022'),('TK00000006',2,20,'2019-11-25','20:53:39','ST013'),('TK00000011',2,10,'2019-11-25','18:07:44','ST013'),('TK00000012',2,14,'2019-11-25','20:41:48','ST001'),('TK00000001',3,16,'2019-11-25','20:52:53','ST005'),('TK00000011',3,10,'2019-11-25','18:08:32','ST001'),('TK00000012',3,13,'2019-11-25','20:42:15','ST016'),('TK00000011',4,10,'2019-11-25','18:09:04','ST023'),('TK00000012',4,13,'2019-11-25','20:54:14','ST003'),('TK00000011',5,15,'2019-11-25','18:09:52','ST005'),('TK00000011',6,20,'2019-11-25','18:40:20','ST012'),('TK00000011',7,15,'2019-11-25','18:40:39','ST019'),('TK00000011',8,11,'2019-11-25','19:29:41','ST001'),('TK00000011',9,16,'2019-11-25','20:54:11','ST002'),('TK00000011',10,20,'2019-11-25','20:58:41','ST021'),('TK00000011',11,20,'2019-11-26','09:18:36','ST023');
/*!40000 ALTER TABLE `ticded` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ticket`
--

DROP TABLE IF EXISTS `ticket`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ticket` (
  `TicketID` varchar(10) NOT NULL,
  `CardID` varchar(10) NOT NULL,
  `PurDate` date NOT NULL,
  `Type` enum('r','n') NOT NULL,
  `CID` varchar(10) DEFAULT NULL,
  `TStatus` enum('empty','paid','inuse','expire','ready') NOT NULL,
  PRIMARY KEY (`TicketID`),
  UNIQUE KEY `TicketID_UNIQUE` (`TicketID`),
  KEY `CID_idx` (`CID`),
  CONSTRAINT `CID` FOREIGN KEY (`CID`) REFERENCES `customer` (`CID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ticket`
--

LOCK TABLES `ticket` WRITE;
/*!40000 ALTER TABLE `ticket` DISABLE KEYS */;
INSERT INTO `ticket` VALUES ('TK00000001','CD00000001','2019-11-25','r','CR00000018','ready'),('TK00000002','CD00000002','2019-11-25','n',NULL,'empty'),('TK00000003','CD00000003','2019-11-25','n',NULL,'empty'),('TK00000004','CD00000004','2019-11-25','n',NULL,'empty'),('TK00000005','CD00000005','2019-11-25','n',NULL,'empty'),('TK00000006','CD00000006','2019-11-25','r','CR00000019','ready'),('TK00000007','CD00000007','2019-11-25','r','CR00000020','ready'),('TK00000008','CD00000008','2019-11-25','r','CR00000021','ready'),('TK00000009','CD00000009','2019-11-25','r','CR00000022','ready'),('TK00000010','CD00000010','2019-11-25','r','CR00000023','ready'),('TK00000011','CD00000011','2019-11-25','r','CR00000024','ready'),('TK00000012','CD00000012','2019-11-25','r','CR00000025','ready'),('TK00000013','CD00000013','2019-11-25','r','CR00000026','ready'),('TK00000014','CD00000014','2019-11-25','r','CR00000027','ready'),('TK00000015','CD00000015','2019-11-25','r','CR00000028','ready'),('TK00000016','CD00000002','2019-11-25','n',NULL,'empty'),('TK00000017','CD00000002','2019-11-25','n',NULL,'empty'),('TK00000018','CD00000016','2019-11-25','n',NULL,'paid'),('TK00000019','CD00000017','2019-11-25','n',NULL,'paid'),('TK00000020','CD00000018','2019-11-25','r','CR00000029','ready'),('TK00000021','CD00000019','2019-11-25','r','CR00000030','ready'),('TK00000022','CD00000002','2019-11-25','n',NULL,'paid'),('TK00000023','CD00000020','2019-11-25','n',NULL,'paid'),('TK00000024','CD00000021','2019-11-25','r','CR00000001','ready'),('TK00000025','CD00000022','2019-11-25','r','CR00000031','ready'),('TK00000026','CD00000023','2019-11-25','r','CR00000013','ready'),('TK00000027','CD00000024','2019-11-25','r','CR00000024','ready'),('TK00000028','CD00000025','2019-11-26','r','CR00000001','ready');
/*!40000 ALTER TABLE `ticket` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tictop`
--

DROP TABLE IF EXISTS `tictop`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tictop` (
  `TicketID` varchar(10) NOT NULL,
  `TicSeq` int(11) NOT NULL,
  `Amount` int(11) NOT NULL,
  `TransacDate` date NOT NULL,
  `TransacTime` time NOT NULL,
  `SID` varchar(5) NOT NULL,
  PRIMARY KEY (`TicketID`,`TicSeq`),
  KEY `SID_idx` (`SID`),
  CONSTRAINT `SID_TicTop` FOREIGN KEY (`SID`) REFERENCES `station` (`SID`),
  CONSTRAINT `TicketID_TicTop` FOREIGN KEY (`TicketID`) REFERENCES `ticket` (`TicketID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tictop`
--

LOCK TABLES `tictop` WRITE;
/*!40000 ALTER TABLE `tictop` DISABLE KEYS */;
INSERT INTO `tictop` VALUES ('TK00000001',1,20,'2019-11-25','14:41:48','ST003'),('TK00000001',2,500,'2019-11-25','16:07:36','ST021'),('TK00000001',3,30,'2019-11-25','20:48:15','ST002'),('TK00000002',1,15,'2019-11-25','14:41:24','ST002'),('TK00000003',1,15,'2019-11-25','15:59:27','ST003'),('TK00000004',1,12,'2019-11-25','15:59:32','ST006'),('TK00000005',1,19,'2019-11-25','15:59:40','ST020'),('TK00000006',1,40,'2019-11-25','16:08:21','ST012'),('TK00000006',2,20,'2019-11-25','18:39:41','ST023'),('TK00000006',3,20,'2019-11-25','20:49:26','ST012'),('TK00000007',1,20,'2019-11-25','20:49:32','ST015'),('TK00000008',1,20,'2019-11-25','18:56:02','ST019'),('TK00000008',2,20,'2019-11-25','20:49:37','ST015'),('TK00000009',1,20,'2019-11-25','20:49:42','ST014'),('TK00000010',1,20,'2019-11-25','20:49:52','ST022'),('TK00000011',1,20,'2019-11-25','18:02:52','ST012'),('TK00000011',2,20,'2019-11-25','18:39:25','ST023'),('TK00000011',3,20,'2019-11-25','18:39:33','ST023'),('TK00000011',4,2,'2019-11-25','18:52:18','ST001'),('TK00000011',5,100,'2019-11-25','19:19:10','ST011'),('TK00000011',6,20,'2019-11-25','19:23:57','ST012'),('TK00000011',7,20,'2019-11-25','20:49:56','ST023'),('TK00000012',1,40,'2019-11-25','20:41:20','ST002'),('TK00000012',2,30,'2019-11-25','20:41:59','ST015'),('TK00000012',3,21,'2019-11-25','20:50:04','ST005'),('TK00000013',1,21,'2019-11-25','20:50:12','ST006'),('TK00000014',1,31,'2019-11-25','20:50:19','ST008'),('TK00000015',1,25,'2019-11-25','20:50:29','ST016'),('TK00000016',1,15,'2019-11-25','19:35:24','ST021'),('TK00000017',1,18,'2019-11-25','20:48:46','ST019'),('TK00000018',1,18,'2019-11-25','20:59:20','ST010'),('TK00000019',1,15,'2019-11-25','20:59:29','ST020'),('TK00000022',1,16,'2019-11-25','21:01:23','ST015'),('TK00000023',1,16,'2019-11-25','21:03:40','ST009');
/*!40000 ALTER TABLE `tictop` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `triphistory`
--

DROP TABLE IF EXISTS `triphistory`;
/*!50001 DROP VIEW IF EXISTS `triphistory`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `triphistory` AS SELECT 
 1 AS `ticketID`,
 1 AS `cardID`,
 1 AS `PurDate`,
 1 AS `Type`,
 1 AS `CID`,
 1 AS `TStatus`,
 1 AS `tripseq`,
 1 AS `status`,
 1 AS `sid_IN`,
 1 AS `SName_IN`,
 1 AS `sid_out`,
 1 AS `SName_OUT`,
 1 AS `date_in`,
 1 AS `time_in`,
 1 AS `date_out`,
 1 AS `time_out`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `triplog`
--

DROP TABLE IF EXISTS `triplog`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `triplog` (
  `TicketID` varchar(10) NOT NULL,
  `TripSeq` int(11) NOT NULL,
  `Time` time NOT NULL,
  `Date` date NOT NULL,
  `Status` enum('enter','exit') NOT NULL,
  `SID` varchar(5) NOT NULL,
  PRIMARY KEY (`TripSeq`,`TicketID`,`Status`),
  KEY `TicketID` (`TicketID`),
  KEY `SID_TripLog_idx` (`SID`),
  CONSTRAINT `SID_TripLog` FOREIGN KEY (`SID`) REFERENCES `station` (`SID`),
  CONSTRAINT `TicketID` FOREIGN KEY (`TicketID`) REFERENCES `ticket` (`TicketID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `triplog`
--

LOCK TABLES `triplog` WRITE;
/*!40000 ALTER TABLE `triplog` DISABLE KEYS */;
INSERT INTO `triplog` VALUES ('TK00000001',1,'16:07:12','2019-11-25','enter','ST001'),('TK00000001',1,'16:07:18','2019-11-25','exit','ST009'),('TK00000002',1,'14:42:06','2019-11-25','enter','ST001'),('TK00000002',1,'14:45:50','2019-11-25','exit','ST007'),('TK00000003',1,'20:51:01','2019-11-25','enter','ST012'),('TK00000003',1,'20:53:12','2019-11-25','exit','ST015'),('TK00000004',1,'20:51:07','2019-11-25','enter','ST005'),('TK00000004',1,'20:53:28','2019-11-25','exit','ST008'),('TK00000005',1,'20:51:13','2019-11-25','enter','ST023'),('TK00000005',1,'20:53:34','2019-11-25','exit','ST009'),('TK00000006',1,'16:08:33','2019-11-25','enter','ST021'),('TK00000006',1,'16:08:43','2019-11-25','exit','ST009'),('TK00000007',1,'20:51:21','2019-11-25','enter','ST011'),('TK00000007',1,'20:53:47','2019-11-25','exit','ST013'),('TK00000008',1,'20:51:25','2019-11-25','enter','ST017'),('TK00000008',1,'20:53:55','2019-11-25','exit','ST018'),('TK00000009',1,'20:51:28','2019-11-25','enter','ST016'),('TK00000009',1,'20:54:00','2019-11-25','exit','ST022'),('TK00000010',1,'20:51:33','2019-11-25','enter','ST014'),('TK00000010',1,'20:54:05','2019-11-25','exit','ST023'),('TK00000011',1,'18:03:44','2019-11-25','enter','ST012'),('TK00000011',1,'18:04:02','2019-11-25','exit','ST023'),('TK00000012',1,'20:41:27','2019-11-25','enter','ST009'),('TK00000012',1,'20:41:33','2019-11-25','exit','ST013'),('TK00000013',1,'20:51:48','2019-11-25','enter','ST012'),('TK00000013',1,'20:54:18','2019-11-25','exit','ST004'),('TK00000014',1,'20:51:52','2019-11-25','enter','ST019'),('TK00000014',1,'20:54:21','2019-11-25','exit','ST005'),('TK00000015',1,'20:51:55','2019-11-25','enter','ST020'),('TK00000015',1,'20:54:28','2019-11-25','exit','ST018'),('TK00000016',1,'20:28:59','2019-11-25','enter','ST012'),('TK00000016',1,'20:29:12','2019-11-25','exit','ST006'),('TK00000017',1,'20:50:54','2019-11-25','enter','ST015'),('TK00000017',1,'20:52:57','2019-11-25','exit','ST023'),('TK00000001',2,'16:08:54','2019-11-25','enter','ST012'),('TK00000001',2,'16:09:03','2019-11-25','exit','ST022'),('TK00000006',2,'20:51:17','2019-11-25','enter','ST002'),('TK00000006',2,'20:53:39','2019-11-25','exit','ST013'),('TK00000011',2,'18:07:26','2019-11-25','enter','ST012'),('TK00000011',2,'18:07:43','2019-11-25','exit','ST013'),('TK00000012',2,'20:41:42','2019-11-25','enter','ST019'),('TK00000012',2,'20:41:47','2019-11-25','exit','ST001'),('TK00000001',3,'20:50:47','2019-11-25','enter','ST021'),('TK00000001',3,'20:52:52','2019-11-25','exit','ST005'),('TK00000011',3,'18:08:13','2019-11-25','enter','ST023'),('TK00000011',3,'18:08:31','2019-11-25','exit','ST001'),('TK00000012',3,'20:42:06','2019-11-25','enter','ST020'),('TK00000012',3,'20:42:15','2019-11-25','exit','ST016'),('TK00000011',4,'18:08:48','2019-11-25','enter','ST001'),('TK00000011',4,'18:09:03','2019-11-25','exit','ST023'),('TK00000012',4,'20:51:43','2019-11-25','enter','ST007'),('TK00000012',4,'20:54:14','2019-11-25','exit','ST003'),('TK00000011',5,'18:09:35','2019-11-25','enter','ST011'),('TK00000011',5,'18:09:51','2019-11-25','exit','ST005'),('TK00000011',6,'18:15:16','2019-11-25','enter','ST001'),('TK00000011',6,'18:40:20','2019-11-25','exit','ST012'),('TK00000011',7,'18:40:33','2019-11-25','enter','ST013'),('TK00000011',7,'18:40:39','2019-11-25','exit','ST019'),('TK00000011',8,'18:43:36','2019-11-25','enter','ST022'),('TK00000011',8,'19:29:41','2019-11-25','exit','ST001'),('TK00000011',9,'20:51:37','2019-11-25','enter','ST018'),('TK00000011',9,'20:54:11','2019-11-25','exit','ST002'),('TK00000011',10,'20:58:32','2019-11-25','enter','ST010'),('TK00000011',10,'20:58:41','2019-11-25','exit','ST021'),('TK00000011',11,'09:18:25','2019-11-26','enter','ST012'),('TK00000011',11,'09:18:36','2019-11-26','exit','ST023');
/*!40000 ALTER TABLE `triplog` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `checktopup`
--

/*!50001 DROP VIEW IF EXISTS `checktopup`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `checktopup` AS with `d` as (select `d`.`TicketID` AS `ticketID`,`d`.`TicSeq` AS `ticseq`,`d`.`Amount` AS `amount`,`d`.`TransacDate` AS `transacdate`,`d`.`TransacTime` AS `transactime`,`d`.`SID` AS `sid` from `ticded` `d` where (`d`.`TicketID`,`d`.`TicSeq`) in (select `d`.`TicketID`,max(`d`.`TicSeq`) from `ticded` `d` group by `d`.`TicketID`)), `t` as (select `t`.`TicketID` AS `ticketID`,`t`.`TicSeq` AS `ticseq`,`t`.`Amount` AS `amount`,`t`.`TransacDate` AS `transacdate`,`t`.`TransacTime` AS `transactime`,`t`.`SID` AS `sid` from `tictop` `t` where (`t`.`TicketID`,`t`.`TicSeq`) in (select `t`.`TicketID`,max(`t`.`TicSeq`) from `tictop` `t` group by `t`.`TicketID`)) select `tic`.`TicketID` AS `ticketID`,(case when ((`d`.`transacdate` is null) or (`t`.`transacdate` > `d`.`transacdate`) or ((`t`.`transacdate` = `d`.`transacdate`) and (`t`.`transactime` > `d`.`transactime`))) then `t`.`ticseq` else `d`.`ticseq` end) AS `SEQ`,(case when ((`d`.`transacdate` is null) or (`t`.`transacdate` > `d`.`transacdate`) or ((`t`.`transacdate` = `d`.`transacdate`) and (`t`.`transactime` > `d`.`transactime`))) then `t`.`amount` else `d`.`amount` end) AS `AMOUNT`,(case when (`t`.`ticseq` is null) then 'NONE' when ((`d`.`transacdate` is null) or (`t`.`transacdate` > `d`.`transacdate`) or ((`t`.`transacdate` = `d`.`transacdate`) and (`t`.`transactime` > `d`.`transactime`))) then 'TOPUP' else 'DEDUCT' end) AS `STATUS` from ((`ticket` `tic` left join `t` on((`tic`.`TicketID` = `t`.`ticketID`))) left join `d` on((`d`.`ticketID` = `t`.`ticketID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `stationview`
--

/*!50001 DROP VIEW IF EXISTS `stationview`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `stationview` AS with `sin` as (select `s`.`SID` AS `SID`,`s`.`SName` AS `SName`,count(`tr`.`TripSeq`) AS `AmountIn` from (`station` `s` left join `triplog` `tr` on(((`s`.`SID` = `tr`.`SID`) and (`tr`.`Status` = 'enter')))) group by `s`.`SID`,`s`.`SName`), `sout` as (select `s`.`SID` AS `SID`,`s`.`SName` AS `SName`,count(`tr`.`TripSeq`) AS `AmountOut` from (`station` `s` left join `triplog` `tr` on(((`s`.`SID` = `tr`.`SID`) and (`tr`.`Status` = 'exit')))) group by `s`.`SID`,`s`.`SName`) select `s`.`SID` AS `SID`,`s`.`SName` AS `SName`,`sin`.`AmountIn` AS `AmountIn`,`sout`.`AmountOut` AS `AmountOut` from ((`station` `s` left join `sin` on((`s`.`SID` = `sin`.`SID`))) left join `sout` on((`s`.`SID` = `sout`.`SID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `triphistory`
--

/*!50001 DROP VIEW IF EXISTS `triphistory`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `triphistory` AS with `trip` as (select `tl1`.`TicketID` AS `ticketID`,`tl1`.`TripSeq` AS `tripSeq`,(case when ((`tl1`.`Status` = 'enter') and (`tl2`.`Status` = 'exit')) then 'OUT' else 'INUSE' end) AS `Status`,`tl1`.`SID` AS `SID_IN`,`s1`.`SName` AS `SName_IN`,`tl2`.`SID` AS `SID_OUT`,`s2`.`SName` AS `SName_OUT`,`tl1`.`Date` AS `DATE_IN`,`tl1`.`Time` AS `TIME_IN`,`tl2`.`Date` AS `DATE_OUT`,`tl2`.`Time` AS `TIME_OUT` from (((`triplog` `tl1` left join `triplog` `tl2` on(((`tl1`.`TicketID` = `tl2`.`TicketID`) and (`tl1`.`TripSeq` = `tl2`.`TripSeq`) and (`tl1`.`Status` = 'enter') and (`tl2`.`Status` <> 'enter')))) left join `station` `s1` on((`tl1`.`SID` = `s1`.`SID`))) left join `station` `s2` on((`tl2`.`SID` = `s2`.`SID`))) where (`tl1`.`Status` = 'enter')) select `t`.`TicketID` AS `ticketID`,`t`.`CardID` AS `cardID`,`t`.`PurDate` AS `PurDate`,(case when (`t`.`Type` = 'r') then 'Register' when (`t`.`Type` = 'n') then 'Non-Register' end) AS `Type`,`t`.`CID` AS `CID`,`t`.`TStatus` AS `TStatus`,`tr`.`tripSeq` AS `tripseq`,ifnull(`tr`.`Status`,'OUT') AS `status`,`tr`.`SID_IN` AS `sid_IN`,`tr`.`SName_IN` AS `SName_IN`,`tr`.`SID_OUT` AS `sid_out`,`tr`.`SName_OUT` AS `SName_OUT`,`tr`.`DATE_IN` AS `date_in`,`tr`.`TIME_IN` AS `time_in`,`tr`.`DATE_OUT` AS `date_out`,`tr`.`TIME_OUT` AS `time_out` from (`ticket` `t` left join `trip` `tr` on((`t`.`TicketID` = `tr`.`ticketID`))) */;
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

-- Dump completed on 2019-11-26 16:29:19
