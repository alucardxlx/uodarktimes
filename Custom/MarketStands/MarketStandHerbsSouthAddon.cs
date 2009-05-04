
////////////////////////////////////////
//                                    //
//      Generated by CEO's YAAAG      //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class MarketStandHerbsSouthAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2448, 0, 1, 6}, {6479, 0, -1, 6}, {3138, 1, 1, 1}// 7	8	11	
			, {3136, 1, 0, 1}// 12	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MarketStandHerbsSouthAddonDeed();
			}
		}

		[ Constructable ]
		public MarketStandHerbsSouthAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( 6787, 0, -1, 0, 0, -1, "market stand" );// 1
			AddComplexComponent( 2938, 0, -1, 1, 0, -1, "market stand" );// 2
			AddComplexComponent( 2938, 0, 0, 1, 0, -1, "market stand" );// 3
			AddComplexComponent( 6787, 0, 1, 0, 0, -1, "market stand" );// 4
			AddComplexComponent( 2938, 0, 1, 1, 0, -1, "market stand" );// 5
			AddComplexComponent( 6274, 0, 0, 6, 0, -1, "basket" );// 6
			AddComplexComponent( 3981, 0, 0, 7, 54, -1, "Chamomile" );// 9
			AddComplexComponent( 3976, 0, 1, 7, 1413, -1, "Meadowsweet" );// 10
			AddComplexComponent( 3135, 1, 1, 1, 0, -1, "dried garlic" );// 13
			AddComplexComponent( 3138, 1, 0, 1, 1429, -1, "Mugwort" );// 14

		}

		public MarketStandHerbsSouthAddon( Serial serial ) : base( serial )
		{
		}

        public void AddComplexComponent(int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(item, xoffset, yoffset, zoffset, hue, lightsource, null);
        }

        public void AddComplexComponent(int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class MarketStandHerbsSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MarketStandHerbsSouthAddon();
			}
		}

		[Constructable]
		public MarketStandHerbsSouthAddonDeed()
		{
			Name = "MarketStandHerbsSouth";
		}

		public MarketStandHerbsSouthAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}