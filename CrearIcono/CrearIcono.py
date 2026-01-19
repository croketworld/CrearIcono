#de momento uso dos vriables: el tetxo de prompt y la ruta del archivo de salida
# Importar librerías necesarias

# Cargar el modelo .safetensors (asegúrate de haberlo convertido al formato Diffusers)
# Si usas un modelo personalizado en .safetensors, primero conviértelo usando:
# python convert_original_stable_diffusion_to_diffusers.py --from_safetensors --checkpoint_path="ruta/modelo.safetensors" --dump_path="ruta/salida"

#ejemplo usando windows cmd:
# python convert_original_stable_diffusion_to_diffusers.py ^
#   --from_safetensors ^
#   --checkpoint_path="C:/Users/Croket/Documents/AI/Models/fantassifiedIcons_fantassifiedIconsV20.safetensors" ^
#   --dump_path="C:/Users/Croket/Documents/AI/Models/diffusers/fantassifiedIcons_fantassifiedIconsV20"   
# o con barras dobles:
#--checkpoint_path="C:\\Users\\Croket\\Documents\\AI\\Models\\fantassifiedIcons_fantassifiedIconsV20.safetensors"   

# Inicializar la tubería con el modelo convertido


From diffusers import DiffusionPipeline
import torch
From PIL import Image
prompt = "{0}"
pipe = DiffusionPipeline.from_pretrained(
    "C:\Users\Croket\Documents\AI\Models\fantassifiedIcons_fantassifiedIconsV20.safetensors",
# Ruta donde guardaste el modelo convertido
torch_dtype=torch.float16,  # Usa precisión media para mejor rendimiento
use_safetensors=True)

pipe.to("cuda")  # Usa GPU (cambia a 'cpu' si no tienes GPU)
# Habilitar atención eficiente en memoria
pipe.enable_xformers_memory_efficient_attention()
# Prompt para generar un ícono
# Generar la imagen
image = pipe(prompt).images
image.save("{1}")
Print("¡Icono generado y guardado como {1}!")