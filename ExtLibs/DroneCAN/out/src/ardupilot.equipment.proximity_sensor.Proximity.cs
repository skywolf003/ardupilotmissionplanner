
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

        public partial class ardupilot_equipment_proximity_sensor_Proximity : IDroneCANSerialize
        {
            public static void encode_ardupilot_equipment_proximity_sensor_Proximity(ardupilot_equipment_proximity_sensor_Proximity msg, dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx, bool fdcan) {
                uint8_t[] buffer = new uint8_t[8];
                _encode_ardupilot_equipment_proximity_sensor_Proximity(buffer, msg, chunk_cb, ctx, !fdcan);
            }

            public static uint32_t decode_ardupilot_equipment_proximity_sensor_Proximity(CanardRxTransfer transfer, ardupilot_equipment_proximity_sensor_Proximity msg, bool fdcan) {
                uint32_t bit_ofs = 0;
                _decode_ardupilot_equipment_proximity_sensor_Proximity(transfer, ref bit_ofs, msg, !fdcan);
                return (bit_ofs+7)/8;
            }

            internal static void _encode_ardupilot_equipment_proximity_sensor_Proximity(uint8_t[] buffer, ardupilot_equipment_proximity_sensor_Proximity msg, dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx, bool tao) {
                memset(buffer,0,8);
                canardEncodeScalar(buffer, 0, 8, msg.sensor_id);
                chunk_cb(buffer, 8, ctx);
                memset(buffer,0,8);
                canardEncodeScalar(buffer, 0, 3, msg.reading_type);
                chunk_cb(buffer, 3, ctx);
                memset(buffer,0,8);
                canardEncodeScalar(buffer, 0, 5, msg.flags);
                chunk_cb(buffer, 5, ctx);
                memset(buffer,0,8);
                {
                    uint16_t float16_val = canardConvertNativeFloatToFloat16(msg.yaw);
                    canardEncodeScalar(buffer, 0, 16, float16_val);
                }
                chunk_cb(buffer, 16, ctx);
                memset(buffer,0,8);
                {
                    uint16_t float16_val = canardConvertNativeFloatToFloat16(msg.pitch);
                    canardEncodeScalar(buffer, 0, 16, float16_val);
                }
                chunk_cb(buffer, 16, ctx);
                memset(buffer,0,8);
                {
                    uint16_t float16_val = canardConvertNativeFloatToFloat16(msg.distance);
                    canardEncodeScalar(buffer, 0, 16, float16_val);
                }
                chunk_cb(buffer, 16, ctx);
            }

            internal static void _decode_ardupilot_equipment_proximity_sensor_Proximity(CanardRxTransfer transfer,ref uint32_t bit_ofs, ardupilot_equipment_proximity_sensor_Proximity msg, bool tao) {

                canardDecodeScalar(transfer, bit_ofs, 8, false, ref msg.sensor_id);
                bit_ofs += 8;

                canardDecodeScalar(transfer, bit_ofs, 3, false, ref msg.reading_type);
                bit_ofs += 3;

                canardDecodeScalar(transfer, bit_ofs, 5, false, ref msg.flags);
                bit_ofs += 5;

                {
                    uint16_t float16_val = 0;
                    canardDecodeScalar(transfer, bit_ofs, 16, true, ref float16_val);
                    msg.yaw = canardConvertFloat16ToNativeFloat(float16_val);
                }
                bit_ofs += 16;

                {
                    uint16_t float16_val = 0;
                    canardDecodeScalar(transfer, bit_ofs, 16, true, ref float16_val);
                    msg.pitch = canardConvertFloat16ToNativeFloat(float16_val);
                }
                bit_ofs += 16;

                {
                    uint16_t float16_val = 0;
                    canardDecodeScalar(transfer, bit_ofs, 16, true, ref float16_val);
                    msg.distance = canardConvertFloat16ToNativeFloat(float16_val);
                }
                bit_ofs += 16;

            }
        }
    }
}