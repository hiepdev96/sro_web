using Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Extentions
{
    public static class ValidationExtension
    {
        public static void ValidationRequired(this string value, string label = "")
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new BusinessException($"Thiếu dữ liệu {label}");
            }
        }

        public static void ValidationRequired(this object value, string label = "")
        {
            if (value == null)
            {
                throw new BusinessException($"Thiếu dữ liệu {label}");
            }
        }
        public static void ValidationRequiredIf(this object value, bool isCheck, string label = "")
        {
            if (isCheck && value == null)
            {
                throw new BusinessException($"Thiếu dữ liệu {label}");
            }
        }

        public static void ValidationRequired<T>(this List<T> value, string label = "")
        {
            if (value == null || value.Count == 0)
            {
                throw new BusinessException($"Thiếu dữ liệu {label}");
            }
        }
        public static void ValidationSize<T>(this List<T> value, string label = "", decimal size = 0)
        {
            if (value == null || value.Count < size)
            {
                throw new BusinessException($"Dữ liệu {label} không được nhỏ hơn {size}");
            }
        }
        public static void ValidationMaxlength(this string value, string label = "", long length = 0)
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Trim().Length > length)
            {
                throw new BusinessException($"Dữ liệu {label} có độ dài vượt quá {length}");
            }
        }

        public static void ValidationInList<T>(this T value, string label, params T[] list)
        {
            if (!list.Contains(value))
            {
                throw new BusinessException(label);
            }
        }
        public static void ValidationUsername(this string value, string label, string pattern)
        {
            if (!value.IsMatchPattern(pattern))
            {
                throw new BusinessException($"Dữ liệu {label} không đúng định dạng");
            }
        }
        public static void ValidationPhone(this string value, string label)
        {
            if (!value.IsValidMobilephone())
            {
                throw new BusinessException($"Dữ liệu {label} không đúng định dạng số điện thoại");
            }
        }
        public static void ValidationEmail(this string value, string label = "")
        {
            if (!string.IsNullOrWhiteSpace(value) && !value.Trim().IsValidEmail())
            {
                throw new BusinessException($"Dữ liệu {label} không đúng định dạng email");
            }
        }

    }
}
