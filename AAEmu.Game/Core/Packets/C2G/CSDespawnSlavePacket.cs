﻿using AAEmu.Commons.Network;
using AAEmu.Game.Core.Managers;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G;

public class CSDespawnSlavePacket : GamePacket
{
    public CSDespawnSlavePacket() : base(CSOffsets.CSDespawnSlavePacket, 5)
    {
        //
    }

    public override void Read(PacketStream stream)
    {
        var slaveObjId = stream.ReadBc();

        // Logger.Debug($"DespawnSlave, SlaveObjId: {slaveObjId}");
        SlaveManager.Instance.Delete(Connection.ActiveChar, slaveObjId, false);
    }
}
