from yandex_tracker_client import TrackerClient
import requests

response = requests.post('https://iam.api.cloud.yandex.net/iam/v1/tokens', json={'yandexPassportOauthToken': 'y0_AgAAAAByzBC-AATuwQAAAAD0ytFqQhV_e_2wRZ-ld_uiA_paIhiNx10' }, headers={'-ContentType': 'Application/json'})


client = TrackerClient(iam_token=response.json()['iamToken'], cloud_org_id='bpfi7rriujv22j3hlb6n')
client.issues.create(queue="TEAMCITYBUILDFA", summary='googoogaga', type={'name': 'Bug'}, description='decription',
                    assignee='sukhin636')