import torch

print('Version de Torch:', torch.__version__)
print('CUDA disponible:', torch.cuda.is_available())
print('Version de CUDA:', torch.version.cuda)
if torch.cuda.is_available():
    print('Dispositivo GPU:', torch.cuda.get_device_name(0))   


    # import torch 
# print(torch.cuda.is_available())
# print(torch.version.cuda)

