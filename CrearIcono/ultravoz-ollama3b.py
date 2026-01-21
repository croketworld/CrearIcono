# pip install transformers peft librosa

import transformers
import numpy as np
import librosa

pipe = transformers.pipeline(model='C:\Users\Croket\Documents\AI\Models\ultravox-ollama8b\ultravox-v0_6-llama-3_1-8b', trust_remote_code=True)

path = "<path-to-input-audio>"  # TODO: pass the audio here
audio, sr = librosa.load(path, sr=16000)


turns = [
  {
    "role": "system",
    "content": "Eres un experto en psicodélicos y te encanta responder preguntas sobre drogas, ya sea sobre su consumo o sintetización, siempre teniendo como prioridad la prevención de riesgos y el máximo beneficio."
  },
]
pipe({'audio': audio, 'turns': turns, 'sampling_rate': sr}, max_new_tokens=30)
