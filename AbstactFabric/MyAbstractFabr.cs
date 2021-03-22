using System;
using System.Collections.Generic;
using System.Text;

namespace AbstactFabric {
	class MyAbstractFabr {

		abstract class MyFabric {
			public abstract ProductA GetProductA();
			public abstract ProductB GetProductB();
		}

		abstract class ProductA {

		}

		abstract class ProductB{

		}

		class ProductA1 : ProductA{
			
		}

		class ProductA2 : ProductA{

		}

		class ProductB1 : ProductB {

		}

		class ProductB2 : ProductB {

		}

		class Fabric1 : MyFabric {
			public override ProductA GetProductA() {
				return new ProductA1();
			}

			public override ProductB GetProductB() {
				return new ProductB1();
			}
		}

		class Fabric2 : MyFabric {
			public override ProductA GetProductA() {
				return new ProductA2();
			}

			public override ProductB GetProductB() {
				return new ProductB2();
			}
		}
	}
}
