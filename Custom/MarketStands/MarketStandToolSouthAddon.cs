
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
	public class MarketStandToolSouthAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3898, 0, 1, 7}, {4148, 0, -1, 7}, {4135, 0, 1, 7}// 6	7	8	
			, {7864, 0, 0, 7}, {4136, 0, -1, 7}, {4140, 0, 1, 8}// 9	10	11	
			, {4138, 0, -1, 8}, {4146, 0, -1, 7}, {4021, 0, 0, 8}// 12	13	14	
			, {3703, 0, 2, 1}// 15	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MarketStandToolSouthAddonDeed();
			}
		}

		[ Constructable ]
		public MarketStandToolSouthAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( 2938, 0, 0, 1, 542, -1, "market stand" );// 1
			AddComplexComponent( 2938, 0, -1, 1, 542, -1, "market stand" );// 2
			AddComplexComponent( 6787, 0, -1, 0, 542, -1, "market stand" );// 3
			AddComplexComponent( 2938, 0, 1, 1, 542, -1, "market stand" );// 4
			AddComplexComponent( 6787, 0, 1, 0, 542, -1, "market stand" );// 5

		}

		public MarketStandToolSouthAddon( Serial serial ) : base( serial )
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

	public class MarketStandToolSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MarketStandToolSouthAddon();
			}
		}

		[Constructable]
		public MarketStandToolSouthAddonDeed()
		{
			Name = "MarketStandToolSouth";
		}

		public MarketStandToolSouthAddonDeed( Serial serial ) : base( serial )
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