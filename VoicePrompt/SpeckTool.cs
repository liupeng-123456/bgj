﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace AutoTF
{
    internal static class SpeckMessage
    {
        public static string OKMsg = "扫码OK";
        public static string NGMsg = "扫码NG";
        private static object lockObject = new object();

        public static int Rate = (int)SystemParams.Instance.VoiceSpeed;
        public static void Speak(string textToSpeak)
        {
            if (!SystemParams.Instance.IsUseVoicePrompt)
            {
                return;
            }
            lock (lockObject)
            {
                // 创建SpeechSynthesizer实例
                using (SpeechSynthesizer synth = new SpeechSynthesizer())
                {
                    // 设置语音输出的声音
                    synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);

                    // 设置语速（可选）
                    synth.Rate = Rate;
                    // 将文本内容转换为语音并进行输出
                    synth.Speak(textToSpeak);
                }
            }
        }

        public static void SpeakAsync(string textToSpeak)
        {
            if (!SystemParams.Instance.IsUseVoicePrompt)
            {
                return;
            }
            Task.Run(() => {
                lock (lockObject)
                {
                    // 创建SpeechSynthesizer实例
                    using (SpeechSynthesizer synth = new SpeechSynthesizer())
                    {
                        // 设置语音输出的声音
                        synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);

                        // 设置语速（可选）
                        synth.Rate = Rate;
                        // 将文本内容转换为语音并进行输出
                        synth.Speak(textToSpeak);
                    }
                }
            });

        }
        public static void Speak(string textToSpeak, int speed = 0)
        {
            lock (lockObject)
            {
                // 创建SpeechSynthesizer实例
                using (SpeechSynthesizer synth = new SpeechSynthesizer())
                {
                    // 设置语音输出的声音
                    synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);

                    // 设置语速（可选）
                    synth.Rate = speed;

                    // 将文本内容转换为语音并进行输出
                    synth.Speak(textToSpeak);
                }
            }
        }
        //语音输出 实现方法2
        //放到一个异步队列里 ，单独开一个线程去持续监控这个队列
        //如果有一条，就抛一条 按顺序进行
    }
}
