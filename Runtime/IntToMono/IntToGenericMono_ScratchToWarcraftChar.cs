using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;

namespace Eloi.ScratchToWarcraft
{
    public class IntToGenericMono_ScratchToWarcraftChar : MonoBehaviour
    {
        public IntToGeneric_ScratchToWarcraftChar m_charEvent = new IntToGeneric_ScratchToWarcraftChar();
        public UnityEvent<char> m_onCharEventParsed = new UnityEvent<char>();
        public List<char> m_charHistory = new List<char>(10);

        public void PushInBytes(byte[] bytes)
        {
            m_charEvent.PushInBytes(bytes, out bool found, out char charFound);
            if (found)
                NotifyEventCharFound(charFound);
        }
        public void PushInInteger(int value)
        {
            m_charEvent.PushInInteger(value, out bool found, out char charFound);
            if (found)
                NotifyEventCharFound(charFound);
        }
        public void PushInEnum(EnumScratchKeyboardWinHardware value)
        {
            m_charEvent.PushInEnum(value, out bool found, out char charFound);
            if (found)
                NotifyEventCharFound(charFound);
        }
        public void PushInBytes(byte[] bytes, out bool found, out char charFound)
        {
            m_charEvent.PushInBytes(bytes, out found, out charFound);
            if (found)
                NotifyEventCharFound(charFound);
        }
        public void PushInInteger(int value, out bool found, out char charFound)
        {
            m_charEvent.PushInInteger(value, out found, out charFound);
            if (found)
                NotifyEventCharFound(charFound);
        }
        public void PushInEnum(EnumScratchKeyboardWinHardware value, out bool found, out char charFound)
        {
            m_charEvent.PushInEnum(value, out found, out charFound);
            if (found)
                NotifyEventCharFound(charFound);
        }
        void NotifyEventCharFound(char charPushed)
        {
            if (m_charHistory.Count >= 10)
                m_charHistory.RemoveAt(0);
            m_charHistory.Add(charPushed);
            m_onCharEventParsed?.Invoke(charPushed);
        }
    }

}