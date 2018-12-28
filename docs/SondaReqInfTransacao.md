# IO.Swagger.Model.SondaReqInfTransacao
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataLocal** | **string** | Data máxima da transação desejada (yyyy-mm-dd) para procurar o NSU em até 7 dias antes desta data/horário. Obs. Campo será tirado de versões futuras, mas ainda necessário e mantido por retro-compatibilidade. | 
**HoraLocal** | **string** | Hora máxima da transação desejada (hh-mm-ss) para procurar o NSU em até 7 dias antes desta data/horário. Obs. Campo será tirado de versões futuras, mas ainda necessário e mantido por retro-compatibilidade. | 
**NsuSonda** | **long?** | NSU da transação de sonda. Necessário para controle interno e rastreabilidade das requisições. | 
**NsuTransacao** | **long?** | NSU da transação desejada. Gerado pelo sistema da SEP. Para casos de teste usar até 10 para retorno cancelado, até 20 para estado confirmado e o resto pendente. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

