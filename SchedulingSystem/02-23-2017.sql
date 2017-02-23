CREATE DATABASE  IF NOT EXISTS `scheduling` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `scheduling`;
-- MySQL dump 10.13  Distrib 5.6.24, for Win64 (x86_64)
--
-- Host: localhost    Database: scheduling
-- ------------------------------------------------------
-- Server version	5.6.26-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `assignedsubj`
--

DROP TABLE IF EXISTS `assignedsubj`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `assignedsubj` (
  `classcode` varchar(50) DEFAULT NULL,
  `subj_desc` varchar(50) DEFAULT NULL,
  `day` varchar(12) DEFAULT NULL,
  `room` varchar(25) DEFAULT NULL,
  `TimeStart` time DEFAULT NULL,
  `TimeEnd` time DEFAULT NULL,
  `instructor` varchar(50) DEFAULT NULL,
  `units` int(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assignedsubj`
--

LOCK TABLES `assignedsubj` WRITE;
/*!40000 ALTER TABLE `assignedsubj` DISABLE KEYS */;
/*!40000 ALTER TABLE `assignedsubj` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `assignedsubj2015-20161st`
--

DROP TABLE IF EXISTS `assignedsubj2015-20161st`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `assignedsubj2015-20161st` (
  `classcode` varchar(50) DEFAULT NULL,
  `subj_desc` varchar(50) DEFAULT NULL,
  `day` varchar(12) DEFAULT NULL,
  `room` varchar(25) DEFAULT NULL,
  `TimeStart` time DEFAULT NULL,
  `TimeEnd` time DEFAULT NULL,
  `instructor` varchar(50) DEFAULT NULL,
  `units` int(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assignedsubj2015-20161st`
--

LOCK TABLES `assignedsubj2015-20161st` WRITE;
/*!40000 ALTER TABLE `assignedsubj2015-20161st` DISABLE KEYS */;
INSERT INTO `assignedsubj2015-20161st` VALUES ('PRIT123BSIT3A','DBMS2','We','ISC301','11:00:00','13:00:00','Valin, Haidee',3),('PRIT123LBSIT3A','DBMS2 (Lab)','Sa','ISC301','14:00:00','17:00:00','Valin, Haidee',1),('PRIT124BSIT3A','Systems Analysis and Design','Mo','ISC301','11:00:00','13:00:00','Valin, Haidee',3),('PRIT124LBSIT3A','Systems Analysis and Design (Lab)','Sa','ISC301','10:30:00','13:30:00','Valin, Haidee',1);
/*!40000 ALTER TABLE `assignedsubj2015-20161st` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `assignedsubj2016-20171st`
--

DROP TABLE IF EXISTS `assignedsubj2016-20171st`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `assignedsubj2016-20171st` (
  `classcode` varchar(50) DEFAULT NULL,
  `subj_desc` varchar(50) DEFAULT NULL,
  `day` varchar(12) DEFAULT NULL,
  `room` varchar(25) DEFAULT NULL,
  `TimeStart` time DEFAULT NULL,
  `TimeEnd` time DEFAULT NULL,
  `instructor` varchar(50) DEFAULT NULL,
  `units` int(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assignedsubj2016-20171st`
--

LOCK TABLES `assignedsubj2016-20171st` WRITE;
/*!40000 ALTER TABLE `assignedsubj2016-20171st` DISABLE KEYS */;
INSERT INTO `assignedsubj2016-20171st` VALUES ('COM110','Computer Fundamentals and Programming','Th','MB101','17:00:00','20:00:00','Musni, Aristotle',3);
/*!40000 ALTER TABLE `assignedsubj2016-20171st` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `existingschoolyearsemester`
--

DROP TABLE IF EXISTS `existingschoolyearsemester`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `existingschoolyearsemester` (
  `schoolyear` varchar(9) NOT NULL,
  `semester` varchar(6) NOT NULL,
  `isActive` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `existingschoolyearsemester`
--

LOCK TABLES `existingschoolyearsemester` WRITE;
/*!40000 ALTER TABLE `existingschoolyearsemester` DISABLE KEYS */;
INSERT INTO `existingschoolyearsemester` VALUES ('2015-2016','1st','true');
/*!40000 ALTER TABLE `existingschoolyearsemester` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facultylist`
--

DROP TABLE IF EXISTS `facultylist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `facultylist` (
  `faculty_id` varchar(15) NOT NULL,
  `faculty_firstname` varchar(255) DEFAULT NULL,
  `faculty_middlename` varchar(255) DEFAULT NULL,
  `faculty_lastname` varchar(255) DEFAULT NULL,
  `faculty_schoolcollege` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`faculty_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facultylist`
--

LOCK TABLES `facultylist` WRITE;
/*!40000 ALTER TABLE `facultylist` DISABLE KEYS */;
INSERT INTO `facultylist` VALUES ('13-00299','Patrick Jenkin','Chan','Wu','Science and Technologies');
/*!40000 ALTER TABLE `facultylist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roomlist`
--

DROP TABLE IF EXISTS `roomlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `roomlist` (
  `room` varchar(25) NOT NULL,
  PRIMARY KEY (`room`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roomlist`
--

LOCK TABLES `roomlist` WRITE;
/*!40000 ALTER TABLE `roomlist` DISABLE KEYS */;
/*!40000 ALTER TABLE `roomlist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roomlist2015-20161st`
--

DROP TABLE IF EXISTS `roomlist2015-20161st`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `roomlist2015-20161st` (
  `room` varchar(25) NOT NULL,
  PRIMARY KEY (`room`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roomlist2015-20161st`
--

LOCK TABLES `roomlist2015-20161st` WRITE;
/*!40000 ALTER TABLE `roomlist2015-20161st` DISABLE KEYS */;
INSERT INTO `roomlist2015-20161st` VALUES ('ISC201'),('ISC301'),('ISC302'),('ISC303'),('ISC401'),('ISC402'),('ISC403'),('ISC501'),('ISC502'),('ISC503'),('ISC601'),('ISC602'),('ISC603');
/*!40000 ALTER TABLE `roomlist2015-20161st` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subject`
--

DROP TABLE IF EXISTS `subject`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subject` (
  `subj_classcode` varchar(50) NOT NULL,
  `subj_desc` text,
  `subj_unit` int(2) DEFAULT NULL,
  PRIMARY KEY (`subj_classcode`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subject`
--

LOCK TABLES `subject` WRITE;
/*!40000 ALTER TABLE `subject` DISABLE KEYS */;
INSERT INTO `subject` VALUES ('COCOM11AAPD2A','COMP. 11 - IT Essentials',3),('COCOM11AAPD2B','COMP. 11 - IT Essentials',3),('COCOM11AAPD2C','COMP. 11 - IT Essentials',3),('COCOM11AAPD2D','COMP. 11 - IT Essentials',3),('COCOM11AAPD2E','COMP. 11 - IT Essentials',3),('COCOM11AAPD2F','COMP. 11 - IT Essentials',3),('COCOM11AAPD2G','COMP. 11 - IT Essentials',3),('COCOM11AAPD2H','COMP. 11 - IT Essentials',3),('COCOM11AAPD2I','Comp. 11 - IT Essentials',3),('COCOM11AAPD2K','COMP. 11 - IT Essentials',3),('COCOM11ABMCB2A','COMP. 11 - IT Essentials',3),('COCOM11ABMCB2B','COMP. 11 - IT Essentials',3),('COCOM11ABMCJ2A','COMP. 11 - IT Essentials',3),('COCOM11ACS1A','COMP. 11 - IT Essentials',3),('COCOM11AIT1A','COMP. 11 - IT Essentials',3),('COCOM11BSA2A','COMP. 11 - IT Essentials',3),('COCOM11BSBAMM2A','COMP. 11 - IT Essentials',3),('COCOM11BSBIO2A','COMP. 11 - IT Essentials',3),('COCOM11BSCPE1A','COMP. 11 - IT Essentials',3),('COCOM11BSMT3A','COMP. 11 - IT Essentials',3),('COCOM11BSMT3C','COMP. 11 - IT Essentials',3),('COCOM11BSMT3E','COMP. 11 - IT Essentials',3),('COCOM11BSMT3G','COMP. 11 - IT Essentials',3),('COCOM11BSMT3I','COMP. 11 - IT Essentials',3),('COCOM11BSMT3K','COMP. 11 - IT Essentials',3),('COCOM11BSMT3M','COMP. 11 - IT Essentials',3),('COCOM11BSMT3O','COMP. 11 - IT Essentials',3),('COCOM11BSMT3Q','COMP. 11 - IT Essentials',3),('COCOM11BSMT3U','COMP. 11 - IT Essentials',3),('COCOM11BSP1A','COMP. 11 - IT Essentials',3),('COCOM11BSP1B','Comp. 11 - IT Essentials',3),('COCOM11BSP1C','COMP. 11 - IT Essentials',3),('COCOM11BSP1D','Comp 11 - IT Essentials',3),('COCOM11BSP1E','COMP. 11 - IT Essentials',3),('COCOM11BSP1F','COMP. 11 - IT Essentials',3),('COCOM11BSP1G','COMP. 11 - IT Essentials',3),('COCOM11BSP1H','COMP. 11 - IT Essentials',3),('COCOM11BSP1I','COMP. 11 - IT Essentials',3),('COCOM11BSP1J','COMP. 11 - IT Essentials',3),('COCOM11BSP1K','COMP. 11 - IT Essentials',3),('COCOM11BSP1L','COMP. 11 - IT Essentials',3),('COCOM11BSP1M','COMP. 11 - IT Essentials',3),('COCOM11BSPSE2A','COMP. 11 - IT Essentials',3),('COCOM11BSPSY2A','COMP. 11 - IT Essentials',3),('COCOM11BSPSY2B','COMP. 11 - IT Essentials',3),('COCOM11BSPSY2C','COMP. 11 - IT Essentials',3),('COCOM11BSTM2A','COMP. 11 - IT Essentials',3),('COCOM11BSTM2B','COMP. 11 - IT Essentials',3),('COCOM11BSTM2C','COMP. 11 - IT Essentials',3),('COCOM11BSTM2D','COMP. 11 - IT Essentials',3),('COCOM11BSTM2E','COMP. 11 - IT Essentials',3),('PCCOM21ABMCB3A','COMP. 21',3),('PCCOM21ABMCB3B','COMP. 11 - IT Essentials',3),('PCCOM21ABMCJ3A','COMP. 21',3),('PCCOM21ABSTM4C','COMP. 21',3),('PCCOM21BSHRM4A','COMP. 21',3),('PCCOM21BSHRM4B','COMP. 21',3),('PCCOM21BSHRM4C','COMP. 21',3),('PCCOM21BSND3A','COMP. 21',3),('PCCOM21BSTM4A','COMP. 21',3),('PCCOM21BSTM4B','COMP. 21',3),('PCCOM21BSTM4D','COMP. 21',3),('PCCOM24DMD1AA','COMP. 24',3),('PCCOM24DMD1BB','COMP. 24',3),('PCCOM31BSBAFM3A','COMP. 31',3),('PCCOM31BSBAMM3A','COMP. 31',3),('PCCPE184BSCPE5A','BSCPE5A',3),('PCCS101AIT2A','CS101',2),('PCCS101LAIT2A','CS101L - Computer Orgranization (lab)',2),('PCCS102BSCS3A','CS102',2),('PCPE156BSCPE5A','CPE156',3),('PCPE191BSCPE5A','CPE191',3),('PRCPE110BSCPE3A','CPE110',3),('PRCPE110LBSCPE3A','CPE110 (lab)',2),('PRCPE112BSCPE3A','CPE112',3),('PRCPE112LBSCPE3A','CPE112 (lab)',2),('PRCPE114BSCPE1A','CPE114',3),('PRCPE115BSCPE3A','CPE115',3),('PRCPE116BSCPE4A','BSCPE4A',3),('PRCPE117BSCPE4A','CPE117',1),('PRCPE119BSCPE3A','CPE119',2),('PRCPE120BSCPE4A','CPE120',2),('PRCPE121BSCPE3A','CPE121',3),('PRCPE126BSCPE5A','CPE126',2),('PRCPE132BSCPE2A','CPE132',3),('PRCPE133BSCPE5A','CPE133',2),('PRCPE133LBSCPE5A','CPE133L',2),('PRCPE141BSCPE3A','CPE141',3),('PRCPE141LBSCPE3A','CPE141L',2),('PRCPE162BSCPE5A','CPE162',3),('PRCPE162LBSCPE5A','CPE162L',2),('PRCPE163BSCPE4A','CPE163',3),('PRCPE164BSCPE4A','CPE164',3),('PRCPE164LBSCPE4A','CPE164L',2),('PRCPE172BSCPE4A','CPE172',3),('PRCPE172LBSCPE4A','CPE172',3),('PRCPE173BSCPE4A','CPE173',3),('PRCPE173LBSCPE4A','CPE173L',2),('PRCS111ACS1A','CS111 - Computer Programming 1',2),('PRCS111AIT1A','CS111L - Computer Programming 1 (lab)',2),('PRCS111LACS1A','CS111L - Computer Programming 1 (lab)',2),('PRCS111LAIT1A','CS111 (Lab) - Programming 1',2),('PRCS114ACS2A','CS114 - Object Oriented Programming',2),('PRCS114AIT2A','CS114',2),('PRCS114LACS2A','CS114L - Object Oriented Programming (lab)',2),('PRCS114LAIT2A','CS114  - Object Oriented Programming (lab)',2),('PRCS115BSCS4A','CS115',2),('PRCS115LBSCS4A','CS115L',2),('PRCS116BSIT3A','CS116',2),('PRCS116LBSIT3A','CS116L - Web Development (lab)',2),('PRCS131ACS2A','CS131 - Discrete Structures',3),('PRCS131AIT2A','CS131 - Discrete Structures',3),('PRCS136ACS2A','CS136',3),('PRCS139BSCS3A','CS139',3),('PRCS191BSCS4A','CS191',3),('PRCSELECT141BSCS3A','CSELECT141',2),('PRCSELECT141LBSCS3A','CSELECT141L - CISCO2',2),('PRCSELECT143BSCS4A','CS Elective 143',2),('PRCSELECT143LBSCS4A','CSELECT143 (Lab)',2),('PRCSFREE151BSCS4A','CSFREE151',2),('PRCSFREE151LBSCS4A','CSFREE151L',2),('PRIT123BSIT3A','DBMS2',3),('PRIT123LBSIT3A','DBMS2 (Lab)',1),('PRIT124BSIT3A','Systems Analysis and Design',3),('PRIT124LBSIT3A','Systems Analysis and Design (Lab)',1),('PRIT182BSIT4A','IT182',3),('PRITELECT141BSIT3A','ITELECT141 - CISCO 2',2),('PRITELECT141LBSIT3A','ITELECT141L - CISCO 2 (lab)',1),('PRPSY110LBSPSY3B','PSY110 - Psychological Statistics',1),('PRPSY110LBSPSY3C','PSY110 - Psychological Statistics',1),('PSCS102LBSCS3A','CS102L',2);
/*!40000 ALTER TABLE `subject` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subjectlist`
--

DROP TABLE IF EXISTS `subjectlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subjectlist` (
  `classcode` varchar(50) NOT NULL,
  `subj_desc` text,
  `subj_unit` int(11) DEFAULT NULL,
  `day` varchar(45) DEFAULT NULL,
  `TimeFrom` time DEFAULT NULL,
  `TimeTo` time DEFAULT NULL,
  `room` varchar(10) DEFAULT NULL,
  `IsAssigned` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`classcode`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subjectlist`
--

LOCK TABLES `subjectlist` WRITE;
/*!40000 ALTER TABLE `subjectlist` DISABLE KEYS */;
INSERT INTO `subjectlist` VALUES ('COCOM11AAPD2A','COMP. 11 - IT Essentials',3,'WeFr','08:30:00','10:00:00','ISC603','false'),('COCOM11AAPD2B','COMP. 11 - IT Essentials',3,'TuTh','10:00:00','11:30:00','ISC601','false'),('COCOM11AAPD2C','COMP. 11 - IT Essentials',3,'TuTh','08:30:00','10:00:00','ISC602','false'),('COCOM11AAPD2D','COMP. 11 - IT Essentials',3,'TuTh','07:00:00','08:30:00','ISC602','false'),('COCOM11AAPD2E','COMP. 11 - IT Essentials',3,'TuTh','14:30:00','16:00:00','ISC503','false'),('COCOM11AAPD2F','COMP. 11 - IT Essentials',3,'TuTh','13:00:00','14:30:00','ISC601','false'),('COCOM11AAPD2G','COMP. 11 - IT Essentials',3,'TuTh','14:30:00','16:00:00','ISC502','false'),('COCOM11AAPD2H','COMP. 11 - IT Essentials',3,'MoSa','14:30:00','16:00:00','ISC603','false'),('COCOM11AAPD2K','COMP. 11 - IT Essentials',3,'TuTh','14:30:00','16:00:00','ISC501','false'),('COCOM11ABMCB2A','COMP. 11 - IT Essentials',3,'TuTh','13:00:00','14:30:00','ISC503','false'),('COCOM11ABMCB2B','COMP. 11 - IT Essentials',3,'WeFr','13:00:00','14:30:00','ISC503','false'),('COCOM11ABMCJ2A','COMP. 11 - IT Essentials',3,'TuTh','10:00:00','11:30:00','ISC502','false'),('COCOM11ACS1A','COMP. 11 - IT Essentials',3,'MoWe','10:00:00','11:30:00','ISC601','false'),('COCOM11AIT1A','COMP. 11 - IT Essentials',3,'FrSa','11:30:00','13:00:00','ISC601','false'),('COCOM11BSA2A','COMP. 11 - IT Essentials',3,'TuTh','07:00:00','08:30:00','ISC501','false'),('COCOM11BSBAMM2A','COMP. 11 - IT Essentials',3,'TuTh','11:30:00','13:00:00','ISC501','false'),('COCOM11BSBIO2A','COMP. 11 - IT Essentials',3,'WeFr','10:00:00','11:30:00','ISC602','false'),('COCOM11BSCPE1A','COMP. 11 - IT Essentials',3,'MoWe','10:00:00','11:30:00','ISC502','false'),('COCOM11BSMT3A','COMP. 11 - IT Essentials',3,'MoWe','08:30:00','10:00:00','ISC503','false'),('COCOM11BSMT3C','COMP. 11 - IT Essentials',3,'MoSa','15:00:00','16:00:00','ISC602','false'),('COCOM11BSMT3E','COMP. 11 - IT Essentials',3,'TuTh','08:30:00','10:00:00','ISC503','false'),('COCOM11BSMT3G','COMP. 11 - IT Essentials',3,'Mo','15:00:00','18:00:00','ISC601','false'),('COCOM11BSMT3I','COMP. 11 - IT Essentials',3,'FrSa','08:30:00','10:00:00','ISC503','false'),('COCOM11BSMT3K','COMP. 11 - IT Essentials',3,'Tu','16:00:00','19:00:00','ISC602','false'),('COCOM11BSMT3M','COMP. 11 - IT Essentials',3,'Sa','14:00:00','17:00:00','ISC503','false'),('COCOM11BSMT3O','COMP. 11 - IT Essentials',3,'Sa','13:30:00','16:30:00','ISC601','false'),('COCOM11BSMT3Q','COMP. 11 - IT Essentials',3,'Sa','07:00:00','10:00:00','ISC502','false'),('COCOM11BSMT3S','COMP. 11 - IT Essentials',3,'Sa','10:30:00','13:30:00','ISC601','false'),('COCOM11BSMT3U','COMP. 11 - IT Essentials',3,'WeFr','07:00:00','08:30:00','ISC602','false'),('COCOM11BSP1A','COMP. 11 - IT Essentials',3,'TuTh','16:00:00','17:30:00','ISC603','false'),('COCOM11BSP1B','COMP. 21',3,'WeFr','07:00:00','08:30:00','ISC603','false'),('COCOM11BSP1C','COMP. 11 - IT Essentials',3,'MoSa','08:30:00','10:00:00','ISC603','false'),('COCOM11BSP1D','Comp 11 - IT Essentials',3,'MoSa','08:30:00','10:00:00','ISC602','false'),('COCOM11BSP1E','COMP. 11 - IT Essentials',3,'WeFr','11:30:00','13:00:00','ISC603','false'),('COCOM11BSP1F','COMP. 11 - IT Essentials',3,'WeFr','11:30:00','13:00:00','ISC602','false'),('COCOM11BSP1G','COMP. 11 - IT Essentials',3,'TuTh','07:00:00','08:30:00','ISC603','false'),('COCOM11BSP1H','COMP. 11 - IT Essentials',3,'WeFr','16:00:00','17:30:00','ISC603','false'),('COCOM11BSP1I','COMP. 11 - IT Essentials',3,'TuTh','14:30:00','16:00:00','ISC603','false'),('COCOM11BSP1J','COMP. 11 - IT Essentials',3,'TuTh','08:30:00','10:00:00','ISC603','false'),('COCOM11BSP1K','COMP. 11 - IT Essentials',3,'TuTh','11:30:00','13:00:00','ISC603','false'),('COCOM11BSP1L','COMP. 11 - IT Essentials',3,'TuTh','11:30:00','13:00:00','ISC602','false'),('COCOM11BSP1M','COMP. 11 - IT Essentials',3,'TuTh','14:30:00','16:00:00','ISC602','false'),('COCOM11BSPSE2A','COMP. 11 - IT Essentials',3,'WeFr','14:30:00','16:00:00','ISC602','false'),('COCOM11BSPSY2A','COMP. 11 - IT Essentials',3,'WeFr','14:30:00','16:00:00','ISC603','false'),('COCOM11BSPSY2B','COMP. 11 - IT Essentials',3,'WeFr','16:30:00','18:00:00','ISC602','false'),('COCOM11BSPSY2C','COMP. 11 - IT Essentials',3,'WeFr','16:00:00','17:30:00','ISC601','false'),('COCOM11BSTM2A','COMP. 11 - IT Essentials',3,'TuTh','07:00:00','08:30:00','ISC503','false'),('COCOM11BSTM2B','COMP. 11 - IT Essentials',3,'WeFr','07:00:00','08:30:00','ISC502','false'),('COCOM11BSTM2C','COMP. 11 - IT Essentials',3,'WeFr','11:30:00','13:00:00','ISC503','false'),('COCOM11BSTM2D','COMP. 11 - IT Essentials',3,'TuTh','11:30:00','13:00:00','ISC403','false'),('COCOM11BSTM2E','COMP. 11 - IT Essentials',3,'WeFr','08:30:00','10:00:00','ISC502','false'),('CSELECT143BSCS4A','CSELECT143',2,'Mo','13:00:00','15:00:00','ISC402','false'),('PCCOM21ABMCB3A','COMP. 21',3,'WeFr','14:30:00','16:00:00','ISC402','false'),('PCCOM21ABMCB3B','COMP. 11 - IT Essentials',3,'TuTh','11:30:00','13:00:00','ISC502','false'),('PCCOM21ABMCJ3A','COMP. 21',3,'TuTh','16:00:00','17:30:00','ISC503','false'),('PCCOM21ABSTM4C','COMP. 21',3,'Th','07:00:00','10:00:00','ISC601','false'),('PCCOM21BSHRM4A','COMP. 21',3,'WeFr','11:30:00','13:00:00','ISC502','false'),('PCCOM21BSHRM4B','COMP. 21',3,'WeFr','13:00:00','14:30:00','ISC603','false'),('PCCOM21BSHRM4C','COMP. 21',3,'TuTh','16:00:00','17:30:00','ISC601','false'),('PCCOM21BSND3A','COMP. 21',3,'MoWe','13:00:00','14:30:00','ISC601','false'),('PCCOM21BSTM4A','COMP. 21',3,'Sa','10:00:00','13:00:00','ISC602','false'),('PCCOM21BSTM4B','COMP. 21',3,'MoSa','11:30:00','13:00:00','ISC603','false'),('PCCOM21BSTM4D','COMP. 21',3,'Mo','16:30:00','19:30:00','ISC603','false'),('PCCOM24DMD1AA','COMP. 24',3,'Fr','07:00:00','10:00:00','ISC601','false'),('PCCOM24DMD1BB','COMP. 24',3,'Tu','07:00:00','10:00:00','ISC601','false'),('PCCOM31BSBAFM3A','COMP. 31',3,'We','15:00:00','19:00:00','ISC503','false'),('PCCOM31BSBAMM3A','COMP. 31',3,'TuTh','16:00:00','17:30:00','ISC502','false'),('PCCPE184BSCPE5A','BSCPE5A',3,'Sa','10:30:00','13:30:00','ISC401','false'),('PCCS101AIT2A','CS101',2,'Mo','13:00:00','15:00:00','ISC302','false'),('PCCS101LAIT2A','CS101L - Computer Orgranization (lab)',2,'Th','07:00:00','10:00:00','ISC302','false'),('PCCS102BSCS3A','CS102',2,'Sa','10:00:00','12:00:00','ISC403','false'),('PCPE156BSCPE5A','CPE156',3,'We','15:00:00','18:00:00','ISC502','false'),('PCPE191BSCPE5A','CPE191',3,'MoWe','11:30:00','13:00:00','ISC303','false'),('PRCPE110BSCPE3A','CPE110',3,'WeFr','13:00:00','14:30:00','ISC302','false'),('PRCPE110LBSCPE3A','CPE110 (lab)',2,'Mo','07:00:00','10:00:00','ISC201','false'),('PRCPE112BSCPE3A','CPE112',3,'Sa','14:00:00','17:00:00','ISC402','false'),('PRCPE112LBSCPE3A','CPE112 (lab)',2,'Fr','16:30:00','19:30:00','ISC201','false'),('PRCPE114BSCPE1A','CPE114',3,'Fr','10:30:00','13:30:00','ISC201','false'),('PRCPE115BSCPE3A','CPE115',3,'TuTh','11:30:00','10:00:00','ISC503','false'),('PRCPE116BSCPE4A','BSCPE4A',3,'Sa','14:00:00','17:00:00','ISC401','false'),('PRCPE117BSCPE4A','CPE117',1,'Fr','12:00:00','13:00:00','ISC501','false'),('PRCPE119BSCPE3A','CPE119',2,'Sa','10:30:00','13:30:00','ISC303','false'),('PRCPE120BSCPE4A','CPE120',2,'Fr','10:00:00','12:00:00','ISC302','false'),('PRCPE126BSCPE5A','CPE126',2,'Th','09:00:00','11:00:00','ISC301','false'),('PRCPE132BSCPE2A','CPE132',3,'FrSa','14:00:00','17:00:00','ISC302','false'),('PRCPE133BSCPE5A','CPE133',2,'Th','14:00:00','16:00:00','ISC402','false'),('PRCPE133LBSCPE5A','CPE133L',2,'Tu','14:00:00','17:00:00','ISC402','false'),('PRCPE141BSCPE3A','CPE141',3,'Fr','10:00:00','13:00:00','ISC301','false'),('PRCPE141LBSCPE3A','CPE141L',2,'Fr','07:00:00','10:00:00','ISC301','false'),('PRCPE162BSCPE5A','CPE162',3,'MoWe','10:00:00','11:30:00','ISC303','false'),('PRCPE162LBSCPE5A','CPE162L',2,'Tu','07:00:00','10:00:00','ISC301','false'),('PRCPE163BSCPE4A','CPE163',3,'Mo','10:30:00','13:30:00','ISC503','false'),('PRCPE164BSCPE4A','CPE164',3,'TuTh','13:00:00','14:30:00','ISC303','false'),('PRCPE164LBSCPE4A','CPE164L',2,'We','07:00:00','10:00:00','ISC303','false'),('PRCPE172BSCPE4A','CPE172',3,'Sa','10:30:00','13:30:00','ISC302','false'),('PRCPE172LBSCPE4A','CPE172',3,'Tu','07:00:00','10:00:00','ISC303','false'),('PRCPE173BSCPE4A','CPE173',3,'WeFr','14:30:00','16:00:00','ISC503','false'),('PRCPE173LBSCPE4A','CPE173L',2,'Sa','07:00:00','10:00:00','ISC401','false'),('PRCS111ACS1A','CS111 - Computer Programming 1',2,'Mo','13:00:00','15:00:00','ISC301','false'),('PRCS111AIT1A','CS111L - Computer Programming 1 (lab)',2,'Th','10:00:00','12:00:00','ISC302','false'),('PRCS111LACS1A','CS111L - Computer Programming 1 (lab)',2,'We','14:00:00','17:00:00','ISC302','false'),('PRCS111LAIT1A','CS111 (Lab) - Programming 1',2,'Tu','10:00:00','13:00:00','ISC302','false'),('PRCS114ACS2A','CS114 - Object Oriented Programming',2,'Mo','13:00:00','15:00:00','ISC303','false'),('PRCS114AIT2A','CS114',2,'Mo','10:00:00','12:00:00','ISC302','false'),('PRCS114LACS2A','CS114L - Object Oriented Programming (lab)',2,'We','14:00:00','17:00:00','ISC303','false'),('PRCS114LAIT2A','CS114  - Object Oriented Programming (lab)',2,'We','10:00:00','13:00:00','ISC302','false'),('PRCS115BSCS4A','CS115',2,'Sa','07:00:00','09:00:00','ISC402','false'),('PRCS115LBSCS4A','CS115L',2,'Th','14:00:00','17:00:00','ISC401','false'),('PRCS116BSIT3A','CS116',2,'Mo','07:00:00','09:00:00','ISC302','false'),('PRCS116LBSIT3A','CS116L - Web Development (lab)',2,'Th','14:00:00','17:00:00','ISC302','false'),('PRCS131ACS2A','CS131 - Discrete Structures',3,'TuTh','14:30:00','16:00:00','ISC303','false'),('PRCS131AIT2A','CS131 - Discrete Structures',3,'TuTh','11:30:00','13:00:00','ISC303','false'),('PRCS136ACS2A','CS136',3,'TuTh','16:00:00','17:30:00','ISC303','false'),('PRCS139BSCS3A','CS139',3,'Sa','07:00:00','10:00:00','ISC302','false'),('PRCS191BSCS4A','CS191',3,'TuTh','11:30:00','13:00:00','ISC401','false'),('PRCSELECT141BSCS3A','CSELECT141',2,'Fr','07:00:00','09:00:00','ISC401','false'),('PRCSELECT141LBSCS3A','CSELECT141L - CISCO2',2,'Th','07:00:00','10:00:00','ISC303','false'),('PRCSELECT143LBSCS4A','CSELECT143 (Lab)',2,'Tu','14:00:00','17:00:00','ISC401','false'),('PRCSFREE151BSCS4A','CSFREE151',2,'We','09:00:00','11:00:00','ISC301','false'),('PRCSFREE151LBSCS4A','CSFREE151L',2,'Sa','14:00:00','17:00:00','ISC303','false'),('PRIT123BSIT3A','DBMS2',3,'We','11:00:00','13:00:00','ISC301','false'),('PRIT123LBSIT3A','DBMS2 (Lab)',1,'Sa','14:00:00','17:00:00','ISC301','false'),('PRIT124BSIT3A','Systems Analysis and Design',3,'Mo','11:00:00','13:00:00','ISC301','false'),('PRIT124LBSIT3A','Systems Analysis and Design (Lab)',1,'Sa','10:30:00','13:30:00','ISC301','false'),('PRIT182BSIT4A','IT182',3,'Sa','10:00:00','13:00:00','ISC503','false'),('PRITELECT141BSIT3A','ITELECT141 - CISCO 2',2,'We','07:00:00','09:00:00','ISC401','false'),('PRITELECT141LBSIT3A','ITELECT141L - CISCO 2 (lab)',1,'Sa','07:00:00','10:00:00','ISC303','false'),('PRPSY110LBSPSY3B','PSY110 - Psychological Statistics',1,'Tu','07:00:00','10:00:00','ISC401','false'),('PRPSY110LBSPSY3C','PSY110 - Psychological Statistics',1,'Mo','07:00:00','10:00:00','ISC403','false'),('PRRRR111AITLA','Sample Subject',3,'Tu','07:00:00','09:00:00','ISC303','false'),('PSCS102LBSCS3A','CS102L',2,'Tu','07:00:00','10:00:00','ISC302','false');
/*!40000 ALTER TABLE `subjectlist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subjectlist2015-20161st`
--

DROP TABLE IF EXISTS `subjectlist2015-20161st`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subjectlist2015-20161st` (
  `classcode` varchar(50) NOT NULL,
  `subj_desc` text,
  `subj_unit` int(11) DEFAULT NULL,
  `day` varchar(45) DEFAULT NULL,
  `TimeFrom` time DEFAULT NULL,
  `TimeTo` time DEFAULT NULL,
  `room` varchar(10) DEFAULT NULL,
  `IsAssigned` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`classcode`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subjectlist2015-20161st`
--

LOCK TABLES `subjectlist2015-20161st` WRITE;
/*!40000 ALTER TABLE `subjectlist2015-20161st` DISABLE KEYS */;
INSERT INTO `subjectlist2015-20161st` VALUES ('COCOM11AAPD2A','COMP. 11 - IT Essentials',3,'Fr','08:30:00','10:00:00','ISC603','false'),('COCOM11AAPD2B','COMP. 11 - IT Essentials',3,'TuTh','10:00:00','11:30:00','ISC601','false'),('COCOM11AAPD2C','COMP. 11 - IT Essentials',3,'TuTh','08:30:00','10:00:00','ISC602','false'),('COCOM11AAPD2D','COMP. 11 - IT Essentials',3,'TuTh','07:00:00','08:30:00','ISC602','false'),('COCOM11AAPD2E','COMP. 11 - IT Essentials',3,'TuTh','14:30:00','16:00:00','ISC503','true'),('COCOM11AAPD2F','COMP. 11 - IT Essentials',3,'TuTh','13:00:00','14:30:00','ISC601','false'),('COCOM11AAPD2G','COMP. 11 - IT Essentials',3,'TuTh','14:30:00','16:00:00','ISC502','false'),('COCOM11AAPD2H','COMP. 11 - IT Essentials',3,'MoSa','14:30:00','16:00:00','ISC603','false'),('COCOM11AAPD2I','Comp. 11 - IT Essentials',3,'TuTh','11:30:00','13:00:00','ISC301','false'),('COCOM11AAPD2K','COMP. 11 - IT Essentials',3,'TuTh','14:30:00','16:00:00','ISC501','false'),('COCOM11ABMCB2A','COMP. 11 - IT Essentials',3,'TuTh','13:00:00','14:30:00','ISC503','false'),('COCOM11ABMCB2B','COMP. 11 - IT Essentials',3,'WeFr','13:00:00','14:30:00','ISC503','false'),('COCOM11ABMCJ2A','COMP. 11 - IT Essentials',3,'TuTh','10:00:00','11:30:00','ISC502','false'),('COCOM11ACS1A','COMP. 11 - IT Essentials',3,'MoWe','10:00:00','11:30:00','ISC601','false'),('COCOM11AIT1A','COMP. 11 - IT Essentials',3,'MoWe','11:30:00','13:00:00','ISC601','false'),('COCOM11BSA2A','COMP. 11 - IT Essentials',3,'TuTh','07:00:00','08:30:00','ISC501','false'),('COCOM11BSBAMM2A','COMP. 11 - IT Essentials',3,'TuTh','11:30:00','13:00:00','ISC501','false'),('COCOM11BSBIO2A','COMP. 11 - IT Essentials',3,'WeFr','10:00:00','11:30:00','ISC602','false'),('COCOM11BSCPE1A','COMP. 11 - IT Essentials',3,'MoWe','10:00:00','11:30:00','ISC502','false'),('COCOM11BSMT3A','COMP. 11 - IT Essentials',3,'MoWe','08:30:00','10:00:00','ISC503','false'),('COCOM11BSMT3C','COMP. 11 - IT Essentials',3,'MoSa','15:00:00','16:30:00','ISC602','false'),('COCOM11BSMT3E','COMP. 11 - IT Essentials',3,'TuTh','08:30:00','10:00:00','ISC503','false'),('COCOM11BSMT3G','COMP. 11 - IT Essentials',3,'Mo','15:00:00','18:00:00','ISC601','false'),('COCOM11BSMT3I','COMP. 11 - IT Essentials',3,'FrSa','08:30:00','10:00:00','ISC503','false'),('COCOM11BSMT3K','COMP. 11 - IT Essentials',3,'Tu','16:00:00','19:00:00','ISC602','false'),('COCOM11BSMT3M','COMP. 11 - IT Essentials',3,'Sa','14:00:00','17:00:00','ISC503','false'),('COCOM11BSMT3O','COMP. 11 - IT Essentials',3,'Sa','13:30:00','16:30:00','ISC601','false'),('COCOM11BSMT3Q','COMP. 11 - IT Essentials',3,'Sa','07:00:00','10:00:00','ISC502','false'),('COCOM11BSMT3U','COMP. 11 - IT Essentials',3,'WeFr','07:00:00','08:30:00','ISC602','false'),('COCOM11BSP1A','COMP. 11 - IT Essentials',3,'TuTh','16:00:00','17:30:00','ISC603','false'),('COCOM11BSP1B','Comp. 11 - IT Essentials',3,'WeFr','07:00:00','08:30:00','ISC603','false'),('COCOM11BSP1C','COMP. 11 - IT Essentials',3,'MoSa','08:30:00','10:00:00','ISC603','false'),('COCOM11BSP1D','Comp 11 - IT Essentials',3,'MoSa','08:30:00','10:00:00','ISC602','false'),('COCOM11BSP1E','COMP. 11 - IT Essentials',3,'WeFr','11:30:00','13:00:00','ISC603','false'),('COCOM11BSP1F','COMP. 11 - IT Essentials',3,'WeFr','11:30:00','13:00:00','ISC602','false'),('COCOM11BSP1G','COMP. 11 - IT Essentials',3,'TuTh','07:00:00','08:30:00','ISC603','false'),('COCOM11BSP1H','COMP. 11 - IT Essentials',3,'WeFr','16:00:00','17:30:00','ISC603','false'),('COCOM11BSP1I','COMP. 11 - IT Essentials',3,'TuTh','14:30:00','16:00:00','ISC603','false'),('COCOM11BSP1J','COMP. 11 - IT Essentials',3,'TuTh','08:30:00','10:00:00','ISC603','false'),('COCOM11BSP1K','COMP. 11 - IT Essentials',3,'TuTh','11:30:00','13:00:00','ISC603','false'),('COCOM11BSP1L','COMP. 11 - IT Essentials',3,'TuTh','11:30:00','13:00:00','ISC602','false'),('COCOM11BSP1M','COMP. 11 - IT Essentials',3,'TuTh','14:30:00','16:00:00','ISC602','false'),('COCOM11BSPSE2A','COMP. 11 - IT Essentials',3,'WeFr','14:30:00','16:00:00','ISC602','false'),('COCOM11BSPSY2A','COMP. 11 - IT Essentials',3,'WeFr','14:30:00','16:00:00','ISC603','false'),('COCOM11BSPSY2B','COMP. 11 - IT Essentials',3,'WeFr','16:30:00','18:00:00','ISC602','false'),('COCOM11BSPSY2C','COMP. 11 - IT Essentials',3,'WeFr','16:00:00','17:30:00','ISC601','false'),('COCOM11BSTM2A','COMP. 11 - IT Essentials',3,'TuTh','07:00:00','08:30:00','ISC503','false'),('COCOM11BSTM2B','COMP. 11 - IT Essentials',3,'WeFr','07:00:00','08:30:00','ISC502','false'),('COCOM11BSTM2C','COMP. 11 - IT Essentials',3,'WeFr','11:30:00','13:00:00','ISC503','false'),('COCOM11BSTM2D','COMP. 11 - IT Essentials',3,'TuTh','11:30:00','13:00:00','ISC403','false'),('COCOM11BSTM2E','COMP. 11 - IT Essentials',3,'WeFr','08:30:00','10:00:00','ISC502','false'),('PCCOM21ABMCB3A','COMP. 21',3,'WeFr','14:30:00','16:00:00','ISC402','false'),('PCCOM21ABMCB3B','COMP. 11 - IT Essentials',3,'TuTh','11:30:00','13:00:00','ISC502','false'),('PCCOM21ABMCJ3A','COMP. 21',3,'TuTh','16:00:00','17:30:00','ISC503','false'),('PCCOM21ABSTM4C','COMP. 21',3,'Th','07:00:00','10:00:00','ISC601','false'),('PCCOM21BSHRM4A','COMP. 21',3,'WeFr','11:30:00','13:00:00','ISC502','false'),('PCCOM21BSHRM4B','COMP. 21',3,'WeFr','13:00:00','14:30:00','ISC603','false'),('PCCOM21BSHRM4C','COMP. 21',3,'TuTh','16:00:00','17:30:00','ISC601','false'),('PCCOM21BSND3A','COMP. 21',3,'MoWe','13:00:00','14:30:00','ISC601','false'),('PCCOM21BSTM4A','COMP. 21',3,'Sa','10:00:00','13:00:00','ISC602','false'),('PCCOM21BSTM4B','COMP. 21',3,'MoSa','11:30:00','13:00:00','ISC603','false'),('PCCOM21BSTM4D','COMP. 21',3,'Mo','16:30:00','19:30:00','ISC603','false'),('PCCOM24DMD1AA','COMP. 24',3,'Fr','07:00:00','10:00:00','ISC601','false'),('PCCOM24DMD1BB','COMP. 24',3,'Tu','07:00:00','10:00:00','ISC601','false'),('PCCOM31BSBAFM3A','COMP. 31',3,'We','15:00:00','19:00:00','ISC503','false'),('PCCOM31BSBAMM3A','COMP. 31',3,'TuTh','16:00:00','17:30:00','ISC502','false'),('PCCPE184BSCPE5A','BSCPE5A',3,'Sa','10:30:00','13:30:00','ISC401','false'),('PCCS101AIT2A','CS101',2,'Mo','13:00:00','15:00:00','ISC302','false'),('PCCS101LAIT2A','CS101L - Computer Orgranization (lab)',2,'Th','07:00:00','10:00:00','ISC302','false'),('PCCS102BSCS3A','CS102',2,'Sa','10:00:00','12:00:00','ISC403','false'),('PCPE156BSCPE5A','CPE156',3,'We','15:00:00','18:00:00','ISC502','false'),('PCPE191BSCPE5A','CPE191',3,'MoWe','11:30:00','13:00:00','ISC303','false'),('PRCPE110BSCPE3A','CPE110',3,'WeFr','13:00:00','14:30:00','ISC302','false'),('PRCPE110LBSCPE3A','CPE110 (lab)',2,'Mo','07:00:00','10:00:00','ISC201','false'),('PRCPE112BSCPE3A','CPE112',3,'Sa','14:00:00','17:00:00','ISC402','false'),('PRCPE112LBSCPE3A','CPE112 (lab)',2,'Fr','16:30:00','19:30:00','ISC201','false'),('PRCPE114BSCPE1A','CPE114',3,'Fr','10:30:00','13:30:00','ISC201','false'),('PRCPE115BSCPE3A','CPE115',3,'TuTh','11:30:00','10:00:00','ISC503','false'),('PRCPE116BSCPE4A','BSCPE4A',3,'Sa','14:00:00','17:00:00','ISC401','false'),('PRCPE117BSCPE4A','CPE117',1,'Fr','12:00:00','13:00:00','ISC501','false'),('PRCPE119BSCPE3A','CPE119',2,'Sa','10:30:00','13:30:00','ISC303','false'),('PRCPE120BSCPE4A','CPE120',2,'Fr','10:00:00','12:00:00','ISC302','false'),('PRCPE121BSCPE3A','CPE121',3,'Sa','07:00:00','10:00:00','ISC301','false'),('PRCPE126BSCPE5A','CPE126',2,'Th','09:00:00','11:00:00','ISC301','false'),('PRCPE132BSCPE2A','CPE132',3,'FrSa','14:00:00','17:00:00','ISC302','false'),('PRCPE133BSCPE5A','CPE133',2,'Th','14:00:00','16:00:00','ISC402','false'),('PRCPE133LBSCPE5A','CPE133L',2,'Tu','14:00:00','17:00:00','ISC402','false'),('PRCPE141BSCPE3A','CPE141',3,'Fr','10:00:00','13:00:00','ISC301','false'),('PRCPE141LBSCPE3A','CPE141L',2,'Fr','07:00:00','10:00:00','ISC301','false'),('PRCPE162BSCPE5A','CPE162',3,'MoWe','10:00:00','11:30:00','ISC303','false'),('PRCPE162LBSCPE5A','CPE162L',2,'Tu','07:00:00','10:00:00','ISC301','false'),('PRCPE163BSCPE4A','CPE163',3,'Mo','10:30:00','13:30:00','ISC503','false'),('PRCPE164BSCPE4A','CPE164',3,'TuTh','13:00:00','14:30:00','ISC303','false'),('PRCPE164LBSCPE4A','CPE164L',2,'We','07:00:00','10:00:00','ISC303','false'),('PRCPE172BSCPE4A','CPE172',3,'Sa','10:30:00','13:30:00','ISC302','false'),('PRCPE172LBSCPE4A','CPE172',3,'Tu','07:00:00','10:00:00','ISC303','false'),('PRCPE173BSCPE4A','CPE173',3,'WeFr','14:30:00','16:00:00','ISC503','false'),('PRCPE173LBSCPE4A','CPE173L',2,'Sa','07:00:00','10:00:00','ISC401','false'),('PRCS111ACS1A','CS111 - Computer Programming 1',2,'Mo','13:00:00','15:00:00','ISC301','false'),('PRCS111AIT1A','CS111L - Computer Programming 1 (lab)',2,'Th','10:00:00','12:00:00','ISC302','false'),('PRCS111LACS1A','CS111L - Computer Programming 1 (lab)',2,'We','14:00:00','17:00:00','ISC302','false'),('PRCS111LAIT1A','CS111 (Lab) - Programming 1',2,'Tu','10:00:00','13:00:00','ISC302','false'),('PRCS114ACS2A','CS114 - Object Oriented Programming',2,'Mo','13:00:00','15:00:00','ISC303','false'),('PRCS114AIT2A','CS114',2,'Mo','10:00:00','12:00:00','ISC302','false'),('PRCS114LACS2A','CS114L - Object Oriented Programming (lab)',2,'We','14:00:00','17:00:00','ISC303','false'),('PRCS114LAIT2A','CS114  - Object Oriented Programming (lab)',2,'We','10:00:00','13:00:00','ISC302','false'),('PRCS115BSCS4A','CS115',2,'Sa','07:00:00','09:00:00','ISC402','false'),('PRCS115LBSCS4A','CS115L',2,'Th','14:00:00','17:00:00','ISC401','false'),('PRCS116BSIT3A','CS116',2,'Mo','07:00:00','09:00:00','ISC302','false'),('PRCS116LBSIT3A','CS116L - Web Development (lab)',2,'Th','14:00:00','17:00:00','ISC302','false'),('PRCS131ACS2A','CS131 - Discrete Structures',3,'TuTh','14:30:00','16:00:00','ISC303','false'),('PRCS131AIT2A','CS131 - Discrete Structures',3,'TuTh','11:30:00','13:00:00','ISC303','false'),('PRCS136ACS2A','CS136',3,'TuTh','16:00:00','17:30:00','ISC303','false'),('PRCS139BSCS3A','CS139',3,'Sa','07:00:00','10:00:00','ISC302','false'),('PRCS191BSCS4A','CS191',3,'TuTh','11:30:00','13:00:00','ISC401','false'),('PRCSELECT141BSCS3A','CSELECT141',2,'Fr','07:00:00','09:00:00','ISC401','false'),('PRCSELECT141LBSCS3A','CSELECT141L - CISCO2',2,'Th','07:00:00','10:00:00','ISC303','false'),('PRCSELECT143BSCS4A','CS Elective 143',2,'Mo','13:00:00','15:00:00','ISC402','false'),('PRCSELECT143LBSCS4A','CSELECT143 (Lab)',2,'Tu','14:00:00','17:00:00','ISC401','false'),('PRCSFREE151BSCS4A','CSFREE151',2,'We','09:00:00','11:00:00','ISC301','false'),('PRCSFREE151LBSCS4A','CSFREE151L',2,'Sa','14:00:00','17:00:00','ISC303','false'),('PRIT123BSIT3A','DBMS2',3,'We','11:00:00','13:00:00','ISC301','true'),('PRIT123LBSIT3A','DBMS2 (Lab)',1,'Sa','14:00:00','17:00:00','ISC301','true'),('PRIT124BSIT3A','Systems Analysis and Design',3,'Mo','11:00:00','13:00:00','ISC301','true'),('PRIT124LBSIT3A','Systems Analysis and Design (Lab)',1,'Sa','10:30:00','13:30:00','ISC301','true'),('PRIT182BSIT4A','IT182',3,'Sa','10:00:00','13:00:00','ISC503','false'),('PRITELECT141BSIT3A','ITELECT141 - CISCO 2',2,'We','07:00:00','09:00:00','ISC401','false'),('PRITELECT141LBSIT3A','ITELECT141L - CISCO 2 (lab)',1,'Sa','07:00:00','10:00:00','ISC303','false'),('PRPSY110LBSPSY3B','PSY110 - Psychological Statistics',1,'Tu','07:00:00','10:00:00','ISC401','false'),('PRPSY110LBSPSY3C','PSY110 - Psychological Statistics',1,'We','14:00:00','17:00:00','ISC403','false'),('PSCS102LBSCS3A','CS102L',2,'Tu','07:00:00','10:00:00','ISC302','false');
/*!40000 ALTER TABLE `subjectlist2015-20161st` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subjectlist2016-20171st`
--

DROP TABLE IF EXISTS `subjectlist2016-20171st`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subjectlist2016-20171st` (
  `classcode` varchar(50) NOT NULL,
  `subj_desc` text,
  `subj_unit` int(11) DEFAULT NULL,
  `day` varchar(45) DEFAULT NULL,
  `TimeFrom` time DEFAULT NULL,
  `TimeTo` time DEFAULT NULL,
  `room` varchar(10) DEFAULT NULL,
  `IsAssigned` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`classcode`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subjectlist2016-20171st`
--

LOCK TABLES `subjectlist2016-20171st` WRITE;
/*!40000 ALTER TABLE `subjectlist2016-20171st` DISABLE KEYS */;
INSERT INTO `subjectlist2016-20171st` VALUES ('COM110','Computer Fundamentals and Programming',3,'Th','17:00:00','20:00:00','MB101','true');
/*!40000 ALTER TABLE `subjectlist2016-20171st` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userlist`
--

DROP TABLE IF EXISTS `userlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `userlist` (
  `fname` varchar(50) DEFAULT NULL,
  `mname` varchar(50) DEFAULT NULL,
  `lname` varchar(50) DEFAULT NULL,
  `username` varchar(20) NOT NULL,
  `password` text,
  `usertype` char(15) DEFAULT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userlist`
--

LOCK TABLES `userlist` WRITE;
/*!40000 ALTER TABLE `userlist` DISABLE KEYS */;
INSERT INTO `userlist` VALUES ('Kail Andrew','Rivera','Hamili','andrewhamili','2a5645647e34d651aca4060b88ddbf539c88a5e03168c7bea6860eefcbe4a72e5b15b7ec38679413773b2861cf9d7a964eb26f492eb3a85d7cc0f79837b5ef4f','User'),('Felipe','','Aguilar Jr.','FAguilar','e54ee7e285fbb0275279143abc4c554e5314e7b417ecac83a5984a964facbaad68866a2841c3e83ddf125a2985566261c4014f9f960ec60253aebcda9513a9b4','User'),('Haidee','','Valin','hvalin','63930cacdca7344693d71968175625df5d09c73a11c948f01bc04150572e09aee2e534205b239c5e6a70ed02bf0c4692c9982fbd69fb475cf97261623cb6ed8d','User'),('Jennifer','','Quieta','jenniferquieta','2dba7398083a3286145bdd61e8948818c0c7f66fbe25240a47cecdb711b03e858c1dd6f254c3c85d305f3d241bc80eebd40a8183120b386c4d5e9982485b9d4c','Administrator'),('Maria Theresa','','Albufera','mtalbufera','e54ee7e285fbb0275279143abc4c554e5314e7b417ecac83a5984a964facbaad68866a2841c3e83ddf125a2985566261c4014f9f960ec60253aebcda9513a9b4','Administrator'),('Group 3','System','Developers','pass','2e3fce77cf8c4c7478a96d207c1c39715892cac84a18cbec9b634f4bc22b390b48cd30a4df2e7ebbaee65c346a662c5be2d12441322f7a4bac821a382c4af091','Administrator'),('Raymond','','Peralta','RPeralta','e54ee7e285fbb0275279143abc4c554e5314e7b417ecac83a5984a964facbaad68866a2841c3e83ddf125a2985566261c4014f9f960ec60253aebcda9513a9b4','User');
/*!40000 ALTER TABLE `userlist` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-02-23 15:30:31
