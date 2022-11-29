-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 29, 2022 at 07:10 AM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `fast_food_restaurant`
--

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `ID` int(11) NOT NULL,
  `Date` varchar(100) NOT NULL,
  `ItemType` varchar(100) NOT NULL,
  `Description` varchar(100) NOT NULL,
  `Unit` varchar(100) NOT NULL,
  `Count` varchar(100) NOT NULL,
  `UnitPrice` varchar(100) NOT NULL,
  `Total` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`ID`, `Date`, `ItemType`, `Description`, `Unit`, `Count`, `UnitPrice`, `Total`) VALUES
(111, 'Wed, 01 Jun 2022, 01:17', 'Ingredients', 'Onion', 'Kilogram', '3', '120.00', '330.00'),
(112, 'Wed, 01 Jun 2022, 01:17', 'Ingredients', 'Garlic', 'Kilogram', '3', '110.00', '294.00'),
(113, 'Wed, 01 Jun 2022, 01:24', 'Utensils', 'Gas Stove', 'Pieces', '1', '1200.00', '1200.00'),
(114, 'Wed, 01 Jun 2022, 01:25', 'Utensils', 'Blender', 'Pieces', '1', '750.00', '750.00'),
(115, 'Wed, 01 Jun 2022, 01:26', 'Utensils', 'Wok', 'Pieces', '2', '160.00', '860.00'),
(116, 'Wed, 01 Jun 2022, 01:27', 'Utensils', 'Whisk', 'Pieces', '3', '26.00', '78.00'),
(117, 'Wed, 01 Jun 2022, 01:28', 'Utensils', 'Pan', 'Pieces', '2', '145.00', '290.00'),
(118, 'Wed, 01 Jun 2022, 01:30', 'Utensils', 'Knife', 'Pieces', '2', '65.00', '130.00'),
(119, 'Wed, 01 Jun 2022, 01:32', 'Utensils', 'Cutting Board', 'Pieces', '1', '53.00', '53.00'),
(120, 'Wed, 01 Jun 2022, 01:33', 'Utensils', 'Microwave', 'Pieces', '1', '1250.00', '1250.00'),
(121, 'Wed, 01 Jun 2022, 01:34', 'Drinks', 'Coke (1.75)', 'Per Bottle', '12', '86.00', '1032.00'),
(122, 'Wed, 01 Jun 2022, 01:35', 'Ingredients', 'Potato', 'Kilogram', '3', '122.00', '366.00'),
(123, 'Wed, 01 Jun 2022, 01:37', 'Ingredients', 'Ground Pork', 'Kilogram', '5', '225.00', '1125.00'),
(124, 'Wed, 01 Jun 2022, 01:38', 'Ingredients', 'Eggs', 'Per Tray', '5', '190.00', '950.00'),
(125, 'Wed, 01 Jun 2022, 01:39', 'Ingredients', 'Salt', 'Kilogram', '10', '40.00', '400.00'),
(126, 'Wed, 01 Jun 2022, 01:40', 'Drinks', 'Sprite (1.75)', 'Per Bottle', '12', '84.00', '1008.00'),
(127, 'Wed, 01 Jun 2022, 01:41', 'Drinks', 'Royal (1.75)', 'Per Bottle', '12', '88.00', '1056.00'),
(128, 'Wed, 01 Jun 2022, 01:42', 'Drinks', 'Nestea', 'Kilogram', '8', '34.00', '272.00'),
(129, 'Wed, 01 Jun 2022, 15:05', 'Drinks', 'Tequila', 'Per Bottle', '10', '635.00', '6350.00');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `ID` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Username` varchar(100) NOT NULL,
  `Password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`ID`, `Name`, `Username`, `Password`) VALUES
(1, 'Marc Eubert', 'admin', 'admin'),
(5, 'Johua', 'user', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `menu_items`
--

CREATE TABLE `menu_items` (
  `ID` int(11) NOT NULL,
  `ItemID` varchar(100) NOT NULL,
  `Description` varchar(100) NOT NULL,
  `Category` varchar(100) NOT NULL,
  `Price` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `menu_items`
--

INSERT INTO `menu_items` (`ID`, `ItemID`, `Description`, `Category`, `Price`) VALUES
(104, '001', 'Coke', 'Drinks', '22.00'),
(105, '002', 'Sprite', 'Drinks', '21.00'),
(106, '003', 'Hamburger', 'Snacks', '32.00'),
(107, '004', 'Fries', 'Snacks', '18.00'),
(108, '005', 'Fried Chiken w/ Rice', 'Meals', '26.00'),
(109, '006', 'Crispy Bangus w/ Rice', 'Meals', '28.00'),
(110, '007', 'Siomai', 'Others', '24.00'),
(111, '008', 'Siopao', 'Snacks', '20.00'),
(112, '009', 'Fish Ball', 'Others', '17.00'),
(113, '010', 'Kwek2', 'Others', '19.00'),
(114, '011', 'Royal', 'Drinks', '23.00'),
(115, '012', 'Iced Tea', 'Drinks', '19.00'),
(116, '013', 'Tequila', 'Drinks', '700.00'),
(117, '235235', 'CRISPY BANGUS', 'Meals', '350.00');

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE `transaction` (
  `ID` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Date` varchar(100) NOT NULL,
  `TotalQTY` varchar(100) NOT NULL,
  `AmmountDue` varchar(100) NOT NULL,
  `Cash` varchar(100) NOT NULL,
  `CashChange` varchar(100) NOT NULL,
  `Status` varchar(100) NOT NULL DEFAULT 'Pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaction`
--

INSERT INTO `transaction` (`ID`, `Name`, `Date`, `TotalQTY`, `AmmountDue`, `Cash`, `CashChange`, `Status`) VALUES
(16, 'Aia Jhernnie', 'Wed, 01 Jun 2022, 15:00', '4', '188.70', '200.00', '11.30', 'Rejected'),
(17, 'Joe Mar', 'Wed, 01 Jun 2022, 19:15', '2', '47.94', '50.00', '2.06', 'Delivered'),
(18, 'Daroy', 'Sat, 04 Jun 2022, 13:24', '1', '714.00', '800.00', '86.00', 'Pending'),
(19, 'Pedro', 'Tue, 21 Jun 2022, 17:49', '2', '51.00', '60.00', '9.00', 'Delivered'),
(20, 'DHXHFHF', 'Tue, 13 Sep 2022, 11:37', '2', '1428.00', '2000.00', '572.00', 'Pending');

-- --------------------------------------------------------

--
-- Table structure for table `transaction_record`
--

CREATE TABLE `transaction_record` (
  `ID` int(11) NOT NULL,
  `Date` varchar(100) NOT NULL,
  `ItemID` varchar(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Description` varchar(100) NOT NULL,
  `Category` varchar(100) NOT NULL,
  `Qty` varchar(100) NOT NULL,
  `Price` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaction_record`
--

INSERT INTO `transaction_record` (`ID`, `Date`, `ItemID`, `Name`, `Description`, `Category`, `Qty`, `Price`) VALUES
(25, 'Wed, 01 Jun 2022, 15:00', '004', 'Aia Jhernnie', 'Fries', 'Snacks', '3', '54.00'),
(26, 'Wed, 01 Jun 2022, 15:00', '011', 'Aia Jhernnie', 'Royal', 'Drinks', '1', '23.00'),
(27, 'Wed, 01 Jun 2022, 19:15', '005', 'Joe Mar', 'Fried Chiken w/ Rice', 'Meals', '1', '26.00'),
(28, 'Wed, 01 Jun 2022, 19:15', '002', 'Joe Mar', 'Sprite', 'Drinks', '1', '21.00'),
(29, 'Sat, 04 Jun 2022, 13:24', '013', 'Daroy', 'Tequila', 'Drinks', '1', '700.00'),
(30, 'Tue, 21 Jun 2022, 17:49', '006', 'Pedro', 'Crispy Bangus w/ Rice', 'Meals', '1', '28.00'),
(31, 'Tue, 21 Jun 2022, 17:49', '001', 'Pedro', 'Coke', 'Drinks', '1', '22.00'),
(32, 'Tue, 13 Sep 2022, 11:36', '235235', 'DHXHFHF', 'CRISPY BANGUS', 'Meals', '2', '700.00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `menu_items`
--
ALTER TABLE `menu_items`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `transaction_record`
--
ALTER TABLE `transaction_record`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `inventory`
--
ALTER TABLE `inventory`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=130;

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `menu_items`
--
ALTER TABLE `menu_items`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=118;

--
-- AUTO_INCREMENT for table `transaction`
--
ALTER TABLE `transaction`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `transaction_record`
--
ALTER TABLE `transaction_record`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
