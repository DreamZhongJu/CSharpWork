# 作业简介
实现对某鸭工厂的产品生产统一管理，主要产品包括鸭脖和鸭翅。武汉工厂能生生产鸭脖和鸭翅，南京工厂只能生产鸭翅，长沙工厂只能生产鸭脖。具体要求如下：

- 定义接口 IProductionFactory，包含生产鸭脖和鸭翅的方法。
- 定义类 WuhanFactory、NanjingFactory、ChangshaFactory 分别实现接口 IProductionFactory，用于具体的生产工厂。
- 使用委托 ProductionDelegate 定义生产委托。
- 在 Main 函数中，创建不同工厂的实例，并通过生产委托进行生产。

# 关联博客地址
https://blog.csdn.net/m0_61319200/article/details/137522274
