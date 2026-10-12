import pathlib,json,hashlib
root=pathlib.Path(__file__).resolve().parents[1]
rows=json.loads((root/'docs/source-manifest.json').read_text(encoding='utf-8'))
bad=[r['path'] for r in rows if not (root/r['path']).is_file() or hashlib.sha256((root/r['path']).read_bytes()).hexdigest()!=r['sha256']]
if bad: raise SystemExit('Changed or missing original files: '+str(bad))
print(f'Verified {len(rows)} original files against preserved SHA-256 hashes.')
