# Luminesync 同照RGB
基于串口的RGB灯效控制软件——上位机代码
RGB lighting control software based on serial ports.
<img width="532" alt="屏幕截图 2021-10-22 150004" src="https://user-images.githubusercontent.com/59970710/138509198-df41d510-206d-4ecc-af8a-bfd403792304.png">

*****
用Arduino或者其他单片机控制装饰灯板/灯条是很常见的事情。也许你在DIY奇光板，也许你在控制装饰灯条，也许你有很多带灯的机箱风扇主板上却没有5vrgb接口。

本项目提供了一个用户友好的，带GUI的上位机控制程序，将在握手成功后通过串口发送和接收颜色信息。

* 预定义了多种灯效模式，并附带有基于Arduino uno的例程。
* 清晰明了的通信协议
* 可用鼠标点击选色，操作直观。

使用方式：具体请见 通信协议.txt
*****

It is very common to control decorative light boards/strips with Arduino or other MCUs. Maybe you're DIYing homemade “Nanoleaf”, maybe you're controlling a decorative light bar, maybe you have a lot of computer fans with RGB but the motherboard has no 5vrgb interface.

This project provides a user-friendly, upper computer control program with GUI that will send and receive color information through the serial port after a successful handshake.

* Predefined multiple light effect modes with DEMO PROGRAM (Arduino uno based).
* Clear and unambiguous communication protocol
* Color selection with mouse click, intuitive operation.

How to use: read 通信协议.txt (Communication Protocol）
