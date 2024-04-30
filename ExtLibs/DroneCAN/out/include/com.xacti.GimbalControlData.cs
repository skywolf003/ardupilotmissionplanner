using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using uint32_t = System.UInt32;
using uint64_t = System.UInt64;

using int8_t = System.SByte;
using int16_t = System.Int16;
using int32_t = System.Int32;
using int64_t = System.Int64;

using float32 = System.Single;

using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace DroneCAN
{
    public partial class DroneCAN 
    {
        public partial class com_xacti_GimbalControlData: IDroneCANSerialize 
        {
            public const int COM_XACTI_GIMBALCONTROLDATA_MAX_PACK_SIZE = 6;
            public const ulong COM_XACTI_GIMBALCONTROLDATA_DT_SIG = 0x3B058FA5B150C5BE;
            public const int COM_XACTI_GIMBALCONTROLDATA_DT_ID = 20554;

            public uint8_t pitch_cmd_type = new uint8_t();
            public uint8_t yaw_cmd_type = new uint8_t();
            public uint16_t pitch_cmd_value = new uint16_t();
            public uint16_t yaw_cmd_value = new uint16_t();

            public void encode(dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx, bool fdcan = false)
            {
                encode_com_xacti_GimbalControlData(this, chunk_cb, ctx, fdcan);
            }

            public void decode(CanardRxTransfer transfer, bool fdcan = false)
            {
                decode_com_xacti_GimbalControlData(transfer, this, fdcan);
            }

            public static com_xacti_GimbalControlData ByteArrayToDroneCANMsg(byte[] transfer, int startoffset, bool fdcan = false)
            {
                var ans = new com_xacti_GimbalControlData();
                ans.decode(new DroneCAN.CanardRxTransfer(transfer.Skip(startoffset).ToArray()), fdcan);
                return ans;
            }
        }
    }
}