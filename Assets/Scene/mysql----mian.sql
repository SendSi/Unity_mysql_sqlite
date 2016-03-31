/*
Navicat MySQL Data Transfer

Source Server         : sunsi
Source Server Version : 50610
Source Host           : localhost:3306
Source Database       : mian

Target Server Type    : MYSQL
Target Server Version : 50610
File Encoding         : 65001

Date: 2016-03-30 23:29:25
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `employee`
-- ----------------------------
DROP TABLE IF EXISTS `employee`;
CREATE TABLE `employee` (
  `id` int(11) DEFAULT NULL,
  `number` int(11) DEFAULT NULL,
  `employeeName` varchar(255) DEFAULT NULL,
  `phone` varchar(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of employee
-- ----------------------------
INSERT INTO `employee` VALUES ('12', '12', '曾思信', '13543403844');
INSERT INTO `employee` VALUES ('12', '12', '曾思信', '13543403844');
INSERT INTO `employee` VALUES ('12', '12', '曾思信', '13543403844');
INSERT INTO `employee` VALUES ('12', '12', '曾思信', '13543403844');
INSERT INTO `employee` VALUES ('12', '12', '曾思信', '13543403844');
INSERT INTO `employee` VALUES ('12', '12', '曾思信', '13543403844');
INSERT INTO `employee` VALUES ('12', '12', '曾思信', '13543403844');
