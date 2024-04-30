
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
using System.Collections.Generic;

namespace DroneCAN
{
    public partial class DroneCAN {

        public partial class uavcan_equipment_hardpoint_Status : IDroneCANSerialize
        {
            public static void encode_uavcan_equipment_hardpoint_Status(uavcan_equipment_hardpoint_Status msg, dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx, bool fdcan) {
                uint8_t[] buffer = new uint8_t[8];
                _encode_uavcan_equipment_hardpoint_Status(buffer, msg, chunk_cb, ctx, !fdcan);
            }

            public static uint32_t decode_uavcan_equipment_hardpoint_Status(CanardRxTransfer transfer, uavcan_equipment_hardpoint_Status msg, bool fdcan) {
                uint32_t bit_ofs = 0;
                _decode_uavcan_equipment_hardpoint_Status(transfer, ref bit_ofs, msg, !fdcan);
                return (bit_ofs+7)/8;
            }

            internal static void _encode_uavcan_equipment_hardpoint_Status(uint8_t[] buffer, uavcan_equipment_hardpoint_Status msg, dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx, bool tao) {
                memset(buffer,0,8);
                canardEncodeScalar(buffer, 0, 8, msg.hardpoint_id);
                chunk_cb(buffer, 8, ctx);
                memset(buffer,0,8);
                {
                    uint16_t float16_val = canardConvertNativeFloatToFloat16(msg.payload_weight);
                    canardEncodeScalar(buffer, 0, 16, float16_val);
                }
                chunk_cb(buffer, 16, ctx);
                memset(buffer,0,8);
                {
                    uint16_t float16_val = canardConvertNativeFloatToFloat16(msg.payload_weight_variance);
                    canardEncodeScalar(buffer, 0, 16, float16_val);
                }
                chunk_cb(buffer, 16, ctx);
                memset(buffer,0,8);
                canardEncodeScalar(buffer, 0, 16, msg.status);
                chunk_cb(buffer, 16, ctx);
            }

            internal static void _decode_uavcan_equipment_hardpoint_Status(CanardRxTransfer transfer,ref uint32_t bit_ofs, uavcan_equipment_hardpoint_Status msg, bool tao) {

                canardDecodeScalar(transfer, bit_ofs, 8, false, ref msg.hardpoint_id);
                bit_ofs += 8;

                {
                    uint16_t float16_val = 0;
                    canardDecodeScalar(transfer, bit_ofs, 16, true, ref float16_val);
                    msg.payload_weight = canardConvertFloat16ToNativeFloat(float16_val);
                }
                bit_ofs += 16;

                {
                    uint16_t float16_val = 0;
                    canardDecodeScalar(transfer, bit_ofs, 16, true, ref float16_val);
                    msg.payload_weight_variance = canardConvertFloat16ToNativeFloat(float16_val);
                }
                bit_ofs += 16;

                canardDecodeScalar(transfer, bit_ofs, 16, false, ref msg.status);
                bit_ofs += 16;

            }
        }
    }
}